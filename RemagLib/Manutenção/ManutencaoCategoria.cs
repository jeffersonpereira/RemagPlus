﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemagLib
{
    public partial class remag_categoria
    {
        public override string ToString()
        {
            return string.Format("{0}-{1}",this.tipo,this.descricao);
        }
    }
}
