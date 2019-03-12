using CxFlatUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxFlatUI.Controls
{
    public class CustomDrawLine : ICustomDrawLine 
    {
        public Pen Pen { get; set; } = new Pen(ThemeColors.OneLevelBorder, 1);
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }

        public CustomDrawLine(Pen pen, int x1, int y1, int x2, int y2)
        {
            Pen = pen;
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }
    }
}
