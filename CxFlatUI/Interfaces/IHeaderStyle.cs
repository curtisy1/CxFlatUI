using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxFlatUI.Interfaces {
    public interface IHeaderStyle {
        ICustomDrawLine DrawLine { get; set; }

        ICustomRectangleF HeaderSize { get; set; }

        Font HeaderFont { get; set; }

        SolidBrush HeaderColor { get; set; }

        StringFormat HeaderAlignment { get; set; }
    }
}
