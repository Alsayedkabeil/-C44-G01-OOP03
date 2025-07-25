using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
    internal interface IShape
    {

        public int Area { get; set; }
        static void DisplayShapeInfo()
        {
            Console.WriteLine("This is a static method in an interface.");
        }
    }
}
