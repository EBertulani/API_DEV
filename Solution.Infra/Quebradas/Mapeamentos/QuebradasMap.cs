using FluentNHibernate.Mapping;

using Solution.Dominio.Quebradas.Entidades;

namespace Solution.Infra.Quebradas.Mapeamentos
{
    public class QuebradasMap : ClassMap<Quebrada>
    {
        public QuebradasMap()
        {
            Schema("DELTA");
            Table("QUEBRADAS");
            Id(x => x.Id).Column("IDQUEBRADA");
            Map(x => x.Origem).Column("ORIGEM");
            Map(x => x.Endereco).Column("ENDERECO");
            Map(x => x.Telefone).Column("TELEFONE");

            HasMany(x => x.Localizacoes)
                .KeyColumn("IDQUEBRADA")
                .Fetch.Subselect();

            ReadOnly();
        }
    }
}
