using Solution.Dominio.Membros.Entidades;

namespace Solution.Dominio.Membros.Servicos.Interfaces
{
    public interface IMembrosServico
    {
        Membro Validar(long? codigo);
    }
}
