using System.Collections.Generic;

using Solution.Dominio.Localizacoes.Entidades;

namespace Solution.Dominio.Quebradas.Entidades
{
    public class Quebrada
    {
        public virtual long Id { get; protected set; }
        public virtual string Telefone { get; protected set; }
        public virtual string Endereco { get; protected set; }
        public virtual string Origem { get; protected set; }

        public virtual IList<Localizacao> Localizacoes { get; protected set; }
    }
}
