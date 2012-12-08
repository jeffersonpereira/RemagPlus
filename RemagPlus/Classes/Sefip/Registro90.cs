using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RemagPlus.Classes.Sefip
{
    public static class Registro90
    {
        public static void GravaRegistro90(this TextWriter file)
        {
            file.Write("90");
            file.Write("9".PadLeft(51, '9'));
            file.Write(' '.ToString().PadRight(306, ' '));
            file.Write("*");
            file.Close();
        }
    }
}
