using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Globalization;

namespace RamagPlus.Importacao.RAIS
{
    public class ReadRais
    {
        public ReadRais(StreamReader file)
        {
            _funcionarios = new List<Funcionario>();
            int linha = 0;
            while (!file.EndOfStream)
            {
                linha++;
                string line = file.ReadLine();
                if (line.Length != 551)
                {
                    throw new ArgumentException(string.Format("Erro na linha {0}. Tamanho da linha incompatível com o Layout da RAIS.",linha));
                }
                if(!line.Substring(22,1).Equals("2"))
                {
                    continue;
                }
                _funcionarios.Add(new Funcionario(line,linha));
            }
        }

        IList<Funcionario> _funcionarios;
        public IList<Funcionario> Funcionarios
        {
            get { return _funcionarios; }
        }
    }
}
