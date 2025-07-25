using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
    internal class Circle : ICircle
    {
        public double Radius { get; set; }
        public double Circumference { get; set; }
        public int Area { get; set; } // Implementing IShape's Area property
        public void CalculateCircumference()
        {
            Circumference = 2 * Math.PI * Radius;
        }
        public void DisplayCircleInfo()
        {
            Console.WriteLine($"Circle with Radius: {Radius}, Circumference: {Circumference}");
        }
    } 
   
}
