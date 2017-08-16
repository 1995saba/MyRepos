using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class RangeOfArray
    {
        private int subscript;
        private int superscript;

        public RangeOfArray()
        {
            subscript = 0;
            superscript = 10;
        }
        public RangeOfArray( int subscript, int superscript)
        {
            this.subscript = subscript;
            this.superscript = superscript;
        }

        public int Subscript { get; set; }

        public int Superscript { get; set; }
    }
}
