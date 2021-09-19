using System;
using System.Collections.Generic;
using System.IO;

using Solution.Dominio.Dossies.Entidades;
using Solution.Dominio.Faccoes.Entidades;
using Solution.Dominio.Investigacoes.Entidades;
using Solution.Dominio.Localizacoes.Entidades;
using Solution.Dominio.Padrinhos.Entidades;
using Solution.Dominio.Processos.Entidades;

namespace Solution.Dominio.Membros.Entidades
{
    public class Membro
    {
        public virtual long Id { get; protected set; }
        public virtual string Nome { get; protected set; }
        public virtual string NomeVulgo { get; protected set; }
        public virtual int Idade { get; protected set; }
        public virtual Faccao Faccao { get; protected set; }
        public virtual DateTime DataBatismo { get; protected set; }
        public virtual DateTime DataCadastro { get; protected set; }
        public virtual string Referencia { get; protected set; }
        public virtual string Matricula { get; protected set; }
        public virtual byte[] Foto { get; protected set; }
        public virtual string CPF { get; protected set; }
        public virtual string NomeMae { get; protected set; }
        public virtual bool Obito { get; protected set; } // validar se é necessario
        public virtual DateTime DataObito { get; protected set; }
        public virtual string LocalObito { get; protected set; }
        public virtual string Caracteristicas { get; protected set; }

        public virtual IList<Padrinho> Padrinhos { get; protected set; }
        public virtual IList<Dossie> Dossies { get; protected set; }
        public virtual IList<Localizacao> Localizacoes { get; protected set; }
        public virtual IList<Investigacao> Investigacoes { get; protected set; }
        public virtual IList<Processo> Processos { get; protected set; }
    }
}
