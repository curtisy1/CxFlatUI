using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxFlatUI.Interfaces
{
    public interface ICustomDrawLine
    {
        Pen Pen { get; set; }

        int X1 { get; set; }

        int Y1 { get; set; }

        int X2 { get; set; }

        int Y2 { get; set; }
    }
}
