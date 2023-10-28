using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barley_break_WPF
{
    public interface IBarleyBreakView
    {
        int[,] Field { get; set; }
        int X { get; set; } 
        int Y { get; set; }
        int Progress { get; set; }

        event EventHandler<EventArgs> MooveEvent;
        event EventHandler<EventArgs> RestartEvent;
    }
}
