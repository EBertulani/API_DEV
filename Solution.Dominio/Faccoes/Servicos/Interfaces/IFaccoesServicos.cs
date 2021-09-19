using Solution.Dominio.Faccoes.Entidades;

namespace Solution.Dominio.Faccoes.Services.Interfaces
{
    public interface IFaccoesServicos
    {
        Faccao Validar(long? codigo);
        Faccao Inserir(string nome, string sigla, string ufOrigem, string anoOrigem, string nomeLider);
        Faccao Editar(long? codigo, string nome, string sigla, string ufOrigem, string anoOrigem, string nomeLider);
        void Excluir(long codigo);

    }
}
