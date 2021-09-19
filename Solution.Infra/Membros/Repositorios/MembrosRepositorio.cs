using NHibernate;

using Solution.Dominio.Membros.Entidades;
using Solution.Dominio.Membros.Repositorios;
using Solution.Infra.Utils;

namespace Solution.Infra.Membros.Repositorios
{
    public class MembrosRepositorio : RepositorioNhibernateBase<Membro>, IMembrosRepositorio
    {
        public MembrosRepositorio(ISession session) : base(session)
        {
        }
    }
}
