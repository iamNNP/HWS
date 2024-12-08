using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication
{
    public sealed class Square : Shape
    {
        private int xCoord { get; set; }
        private int yCoord { get; set; }
        public Square(int x, int y)
        {
            xCoord = x;
            yCoord = y;
        }
    }
}
