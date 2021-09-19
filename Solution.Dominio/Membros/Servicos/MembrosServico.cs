using System;

using Solution.Dominio.Membros.Repositorios;
using Solution.Dominio.Membros.Entidades;
using Solution.Dominio.Membros.Servicos.Interfaces;

namespace Solution.Dominio.Membros.Servicos
{
    public class MembrosServico : IMembrosServico
    {
        private readonly IMembrosRepositorio membrosRepositorio;

        public MembrosServico(IMembrosRepositorio membrosRepositorio)
        {
            this.membrosRepositorio = membrosRepositorio;
        }
        public Membro Validar(long? codigo)
        {
            if (codigo is null)
                throw new Exception("Codigo do membro invalida");
            Membro entidade = membrosRepositorio.Recuperar(codigo.Value);
            if (entidade is null)
                throw new Exception("Membro não encontrada");
            return entidade;
        }
    }
}
