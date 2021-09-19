using System;
using System.Collections.Generic;

using Solution.Dominio.Membros.Entidades;
using Solution.Dominio.Quebradas.Entidades;

namespace Solution.Dominio.Localizacoes.Entidades
{
    public class Localizacao
    {
        public virtual Membro Membro { get; protected set; }
        public virtual Quebrada Quebrada { get; protected set; }
        public virtual DateTime DataInicio { get; protected set; }
        public virtual DateTime DataFim { get; protected set; }

        public override bool Equals(object obj)
        {
            return obj is Localizacao localizacao &&
                   Membro.Id == localizacao.Membro.Id &&
                   Quebrada.Id == localizacao.Quebrada.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Membro.Id, Quebrada.Id);
        }
    }
}
