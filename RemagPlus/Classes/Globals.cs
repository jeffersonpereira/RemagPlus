using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Windows.Forms;
using RemagLib;

namespace RemagPlus.Classes
{
    public static class Globals
    {

        public static remag_empresa Empresa { get; set; }
        public static remag_usuario UsuarioAtual { get; set; }
        public static bool IsDemo 
        { 
            get { return true; } 
        }

        public static List<ComboPreenchido> CodigoRecolhimento
        {
            get
            {
                List<ComboPreenchido> codigo = new List<ComboPreenchido>();
                codigo.Add(new ComboPreenchido(115, "115 - Recolhimento ao FGTS e informações à Previdência Social"));
                codigo.Add(new ComboPreenchido(130, "130 - Recolhimento ao FGTS e informações à Previdência Social relativas ao trabalhador avulso Portuário"));
                codigo.Add(new ComboPreenchido(135, "135 - Recolhimento ao FGTS e informações à Previdência Social relativas ao trabalhador avulso não portuário"));
                codigo.Add(new ComboPreenchido(145, "145 - Recolhimento ao FGTS de diferenças apuradas pela CAIXA"));
                codigo.Add(new ComboPreenchido(150, "150 - Recolhimento ao FGTS e informações à Previdência Social de empresa prestadora de serviços"
                + "com cessão de mão-de-obra e empresa de trabalho temporário - Lei n. 6.019/74, em relação aos empregados cedidos, ou de obra de construção civil - empreitada parcial."));
                codigo.Add(new ComboPreenchido(155, "155 - Recolhimento ao FGTS e informações à Previdência Social de obra de construção civil - empreitada total ou obra própria"));
                codigo.Add(new ComboPreenchido(211, "211 - Declaração para a Previdência Social de Cooperativa de Trabalho relativa aos contribuintes individuais cooperados"));
                codigo.Add(new ComboPreenchido(307, "307 - Declaração para a Previdência Social de Cooperativa de Trabalho relativa aos contribuintes individuais cooperados"));
                codigo.Add(new ComboPreenchido(327, "327 - Declaração para a Previdência Social de Cooperativa de Trabalho relativa aos contribuintes individuais cooperados"));
                return codigo;
            }
        }

        public static List<ComboPreenchido> Modalidade
        {
            get
            {
                List<ComboPreenchido> modalidade = new List<ComboPreenchido>();
                modalidade.Add(new ComboPreenchido(" ", "Branco - Recolhimento ao FGTS e Declaração para a Previdência"));
                modalidade.Add(new ComboPreenchido("1", "1 - Declaração ao FGTS e à Previdência"));
                modalidade.Add(new ComboPreenchido("9", "9 - Confirmação/Retificação de informações anteriores"));
                return modalidade;
            }
        }
    }


    public static class Mensagens
    { 
      public const string Salvo="Registro Salvo com sucesso!";
      public const string Excluido = "Registro Excluído com sucesso!";
      public const string PerguntaExclusao = "Tem certeza que deseja excluir este registro?";
      public const string Titulo = "Remag Plus";
    }
}
