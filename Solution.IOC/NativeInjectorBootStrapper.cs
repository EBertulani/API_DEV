using System.Reflection;

using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using NHibernate;
using NHibernate.Tool.hbm2ddl;

using Solution.Aplicacao.Faccoes.Profiles;
using Solution.Aplicacao.Faccoes.Servicos;
using Solution.Dominio.Faccoes.Services;
using Solution.Dominio.Utils;
using Solution.Infra.Faccoes.Mapeamentos;
using Solution.Infra.Faccoes.Repositorios;
using Solution.Infra.Utils;

namespace Solution.IOC
{
    public class NativeInjectorBootStrapper
    {
        private static ISessionFactory CreateSession<T>(IPersistenceConfigurer configurer)
        {
            return Fluently.Configure()
                .Database(configurer)
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<T>())
                .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true))
                .BuildConfiguration()
                .BuildSessionFactory();
        }
        private static IPersistenceConfigurer PersistenceConfiguration(IConfiguration configuration, IHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                return SQLiteConfiguration.Standard
                                          .UsingFile(configuration.GetSection("FilePath").Value)
                                          .FormatSql()
                                          .ShowSql();
            }
            if(env.IsEnvironment("Hml"))
            {
                return MySQLConfiguration.Standard
                                          .ConnectionString(configuration.GetConnectionString("Connection"));
            }
            return null;
        }
        public static void InjectServices(IServiceCollection services, IConfiguration configuration, IHostEnvironment env)
        {
            IPersistenceConfigurer persistenceConfiguration = PersistenceConfiguration(configuration, env);
            services.AddSingleton(factory => CreateSession<FaccoesMap>(persistenceConfiguration));
            services.AddScoped<ISession>(factory =>
            {
                return factory.GetService<ISessionFactory>().OpenSession();
            });
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddAutoMapper(typeof(FaccoesProfile).GetTypeInfo().Assembly);

            services.Scan(scan => scan.
                                    FromAssemblyOf<FaccoesServicos>()
                                    .AddClasses()
                                    .AsImplementedInterfaces()
                                    .WithTransientLifetime());

            services.Scan(scan => scan.
                                    FromAssemblyOf<FaccoesAppServico>()
                                    .AddClasses()
                                    .AsImplementedInterfaces()
                                    .WithTransientLifetime());

            services.Scan(scan => scan.
                                    FromAssemblyOf<FaccoesRepositorio>()
                                    .AddClasses()
                                    .AsImplementedInterfaces()
                                    .WithTransientLifetime());

        }
    }
}
