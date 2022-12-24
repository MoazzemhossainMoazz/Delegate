using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Rectangle
    {
        public void GetArea(double width, double height)
        {
            Console.WriteLine("Area of Rectangle: "+ width* height);
        }

        public void GetPerimeter(double width, double height)
        {
            Console.WriteLine("Perimeter of Rectangle: " + 2 * (width + height));
        }

    }
}
