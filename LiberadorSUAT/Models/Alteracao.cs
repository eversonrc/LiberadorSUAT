using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiberadorSUAT.Models
{
    public class Alteracao
    {
        public string HelpDesk { get; set; }
        public string Responsavel { get; set; }
        public string Descricao { get; set; }
        public string AlteracaoRealizada { get; set; }


        public Alteracao (string helpdesk, string responsavel, string descricao, string alteracao)
        {
            HelpDesk = helpdesk;
            Responsavel = responsavel;
            Descricao = descricao;
            AlteracaoRealizada = alteracao;
        }

        public override string ToString()
        {
            return "Helpdesk: " + HelpDesk +
                    "Responsável: " + Responsavel +
                    "Descrição do chamado: " + Descricao +
                    "Alteração realizada: " + AlteracaoRealizada;
        }
    }
}
