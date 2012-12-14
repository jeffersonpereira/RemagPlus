using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace RamagPlus.Importacao
{
    public class Line
    {
        List<LineItem> _items = new List<LineItem>();
        protected void AddLine(LineItem item)
        {
            _items.Add(item);
        }

        public T GetValue<T>(int position)
        {
            LineItem item = _items.FirstOrDefault(i => i.Position == position);
            var value = item.GetItem();
            if (typeof(int).Equals(typeof(T)) && value == " ")
            {
                value = "0";
            }
            return (T)Convert.ChangeType(value, typeof(T));
        }

        public DateTime GetValue(int position, string format)
        {
            LineItem item = _items.FirstOrDefault(i => i.Position == position);
            var value = item.GetItem();
            DateTime data = DateTime.ParseExact(value, format, CultureInfo.InvariantCulture);
            return data;
        }

        public decimal GetValue(int position, int casasDecimais = 2)
        {
            LineItem item = _items.FirstOrDefault(i => i.Position == position);
            var value = item.GetItem();
            return value.StrToDecimal(casasDecimais);
        }

        public IList<LineItem> Itens
        {
            get { return _items; }
        }
    }
}
