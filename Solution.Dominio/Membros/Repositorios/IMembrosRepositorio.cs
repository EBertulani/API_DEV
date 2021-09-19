using Solution.Dominio.Membros.Entidades;

namespace Solution.Dominio.Membros.Repositorios
{
    public interface IMembrosRepositorio
    {
        Membro Recuperar(long id);
    }
}
