using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication
{
    public abstract class Shape
    {
        public bool Init { get; }
        protected static int r;
        static Shape()
        {
            r = 0;
        }
    }
}
