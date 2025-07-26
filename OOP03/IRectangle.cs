using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{ //sss
    internal interface IRectangle:IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Perimeter { get; set; }
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
