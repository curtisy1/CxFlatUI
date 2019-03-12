using CxFlatUI.Controls;
using CxFlatUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxFlatUI.CustomTypes {
    public class HeaderStyle : IHeaderStyle {
        public ICustomDrawLine DrawLine { get; set; }
        public ICustomRectangleF HeaderSize { get; set; }
        public Font HeaderFont { get; set; }
        public SolidBrush HeaderColor { get; set; }
        public StringFormat HeaderAlignment { get; set; }

        public HeaderStyle(CustomDrawLine line, CustomRectangleF size, Font font, SolidBrush color, StringFormat alignment) {
            DrawLine = line;
            HeaderSize = size;
            HeaderFont = font;
            HeaderColor = color;
            HeaderAlignment = alignment;
        }
    }
}
