using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barley_break_WPF
{
    internal interface IModel
    {
        public int[,] Field { get; set; }
    }
}
