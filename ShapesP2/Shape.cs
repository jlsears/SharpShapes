using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapesP2
{
    public abstract class Shape : IShape
    {
        // We need info about colors
        // Need to peer into wpf framework to see how to even define color something can be drawn
        Color fillColor;
        Color borderColor;
        
        public Color FillColor { get;  }
        public Color BorderColor { get; }

        // Need to make sure these methods can be overwritten

        public float Area() { throw new NotImplementedException(); }
        public float Perimeter() { throw new NotImplementedException(); }
    }
}
