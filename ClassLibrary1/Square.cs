using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpShapes
{
    public class Square : Rectangle
    {
        private decimal side;
        public decimal Side 
        { 
            get { return this.side; } 
        }

        public Square(int side) : base (side, side)
        {
            this.side = side;
        }
    } 
}
