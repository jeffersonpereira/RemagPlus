using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace RamagPlus.Importacao
{
    public class LineItem
    {
        readonly string _line;
        readonly int _number;
        readonly int _position;
        readonly int _length;
        readonly string _nome;
        public LineItem(string nome, string value, int position, int length)
        {
            _line = value;
            _nome = nome;
            _position = position;
            _length = length;
            _number++;
        }

        public int Number
        {
            get { return _number; }
        }

        public int Position
        {
            get { return _position; }
        }

        public int Length
        {
            get { return _length; }
        }

        public string Nome
        {
            get { return _nome; }
        }

        public string GetItem()
        {
            var value = _line.Substring(Position - 1, Length);
            return value;
        }
    }
}
