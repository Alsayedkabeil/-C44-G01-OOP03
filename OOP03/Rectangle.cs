using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
    internal class Rectangle: IRectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Perimeter { get; set; }
        public int Area { get; set; } // Implementing IShape's Area property
        public void CalculatePerimeter()
        {
            Perimeter = 2 * (Length + Width);
        }
        public void DisplayRectangleInfo()
        {
            Console.WriteLine($"Rectangle with Length: {Length}, Width: {Width}, Perimeter: {Perimeter}");
        }
    }
    


    
}
