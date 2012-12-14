using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamagPlus.Importacao
{
    public enum TipoDeficiencia
    {
        Nenhuma,
        Fisica,
        Auditiva,
        Visual,
        Intelectual,
        Multipla,
        Reabilitado
    }

    public enum Sexo
    { 
        Masculino = 1,
        Feminino = 2
    }

    public enum TipoNacionalidade
    { 
        Venezuelano = 26,
        Colombiano = 27,
        Peruano = 28,
        Equatoriano = 29,
        Haitiano = 40,
        Russo = 44,
        Paquistanês = 46,
        Indiano = 47,
        OutrosEuropeus = 51,
        Angolano = 60,
        Congolês = 61,
        SulAfricano = 62,
        OutrosAfricanos = 70,
        Outros = 80
    }

    public enum TipoAdmissao
    { 
        Reversao = 7,
        ExercicioProvisorio = 9,
        Readaptação = 10,
        Redistribuicao = 11,
        ExercicioDescentralizado = 12,
        Remocao = 13
    }

    public class Funcionario : Line
    {
        int linha;
        public Funcionario(string line,int linha)
        {
            this.linha = linha;
            AddLine(new LineItem("PIS/PASEP", line, 24, 11));
            AddLine(new LineItem("Nome", line, 35, 52));
            AddLine(new LineItem("Data de Nascimento", line, 87, 8));
            AddLine(new LineItem("Nacionalidade", line, 95, 2));
            AddLine(new LineItem("Ano de Chegada", line, 97, 4));
            AddLine(new LineItem("Grau de Instrução", line, 101, 2));
            AddLine(new LineItem("CPF", line, 103, 11));
            AddLine(new LineItem("CTPS", line, 114, 8));
            AddLine(new LineItem("Série", line, 122, 5));
            AddLine(new LineItem("Data de Admissão", line, 127, 8));
            AddLine(new LineItem("Tipo de Admissão", line, 135, 2));
            AddLine(new LineItem("Salário Contratual", line, 137, 9));
            AddLine(new LineItem("Tipo de Salário Contratual", line, 146, 1));
            AddLine(new LineItem("Horas Semanais", line, 147, 2));
            AddLine(new LineItem("CBO", line, 149, 6));
            AddLine(new LineItem("Vínculo", line, 155, 2));
            AddLine(new LineItem("Indicador de deficiência", line, 294, 1));
            AddLine(new LineItem("Tipo de deficiência", line, 295, 1));
            AddLine(new LineItem("Sexo", line, 306, 1));
            AddLine(new LineItem("Filiado a Sindicato", line, 539, 1));
            AddLine(new LineItem("CNPJ do Sindicato", line, 386, 14));
            AddLine(new LineItem("Município", line, 496, 7));
        }

        public int Linha
        {
            get { return linha; }
        }

        public string CPF
        {
            get { return GetValue<string>(103); }
        }

        public string PIS
        {
            get { return GetValue<string>(24); }
        }

        public string Nome
        {
            get { return GetValue<string>(35); }
        }

        public DateTime Nascimento
        {
            get { return GetValue(87, "ddMMyyyy"); }
        }

        public TipoNacionalidade Nacionalidade
        {
            get { return (TipoNacionalidade)GetValue<int>(95); }
        }

        public int AnoChegada
        {
            get { return GetValue<int>(97); }
        }

        public int Municipio
        {
            get { return GetValue<int>(496); }
        }

        public int GrauInstrucao
        {
            get { return GetValue<int>(101); }
        }

        public int CTPS
        {
            get { return GetValue<int>(114); }
        }

        public string SerieCTPS
        {
            get { return GetValue<string>(122); }
        }

        public DateTime Admissao
        {
            get { return GetValue(127,"ddMMyyyy"); }
        }

        public TipoAdmissao TipoAdmissao
        {
            get { return (TipoAdmissao)GetValue<int>(135); }
        }

        public decimal SalarioContratual
        {
            get { return GetValue(137); }
        }

        public int TipoSalario
        {
            get { return GetValue<int>(146); }
        }

        public int HorasSemanais
        {
            get { return GetValue<int>(147); }
        }

        public int CBO
        {
            get { return GetValue<int>(149); }
        }

        public int Vinculo
        {
            get { return GetValue<int>(155); }
        }
        public bool IsDeficiente
        {
            get { return GetValue<int>(294) == 1; }
        }

        public TipoDeficiencia TipoDeDeficiencia
        {
            get { return (TipoDeficiencia)GetValue<int>(295); }
        }

        public Sexo Sexo
        {
            get { return (Sexo)GetValue<int>(306); }
        }

        public bool IsSindicalizado
        {
            get { return GetValue<int>(539) == 1; }
        }

        public string CnpjSindicato
        {
            get
            {
                if (IsSindicalizado)
                {
                    return GetValue<string>(386);
                }
                return string.Empty;
            }
        }

    }
}
