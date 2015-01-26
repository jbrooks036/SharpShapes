using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; // added for Color

namespace SharpShapes   
{
    abstract public class Shape
    {
        // Width, Height, Perimeter, Area, BorderColor, FillColor, NumberOfSides
        // properties?  or calculated?

        /// <summary>
        /// The color of the interior of the shape.
        /// </summary>
        public Color FillColor { get; set; }
        
        /// <summary>
        /// The color of the border of the shape, when drawn.
        /// </summary>
        public Color BorderColor { 
            get; 
            set; }

        /// <summary>
        /// The number of sides of this shape.
        /// </summary>
        abstract public int SidesCount { get; }
        
        public Shape()
        {
            BorderColor = Color.Tomato;
            FillColor = Color.Bisque;
        }
        /// <summary>
        /// Calculates the area of the shape.
        /// </summary>
        // <returns> the area of this shape </returns>
        abstract public decimal Area();

        /// <summary>
        /// Calculates the perimeter of the shape.
        /// </summary>
        // <returns> the perimeter of this shape </returns>
        abstract public decimal Perimeter();

        /// <summary>
        /// Scales the shape in size.
        /// </summary>
        ///<param name="percent"> the percentage by which to scale the shape </param>
        abstract public void Scale (int percent);
    
    }
}
