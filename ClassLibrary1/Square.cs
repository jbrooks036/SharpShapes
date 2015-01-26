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
            // if (side)
            //     throw new ArgumentException();
            this.side = side;
        }

        public override void Scale(int percent)
        {
            if (percent <= 0)
            {
                throw new ArgumentException();
            }
            this.side = percent * side / 100;
            base.Scale(percent);
        }
    } 
}
