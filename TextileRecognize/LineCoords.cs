using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextileRecognizer
{
    class LineCoords
    {
        public int x0 { get; private set; }
        public int x1 { get; private set; }
        public int y0 { get; private set; }
        public int y1 { get; private set; }

        public LineCoords(int X0, int Y0, int X1, int Y1)
        {         
            x0 = X0;
            x1 = X1;
            y0 = Y0;
            y1 = Y1;
        }
        public int GetWidth() { return x1 - x0; }
        public int GetHieght() { return y1 - y0; }
    }
}
