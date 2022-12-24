using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void RectDel(double x, double y);
    class Program
    {
        public static int AddNums(int num1, int num2)
        {
            return num1 + num2;
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            RectDel rectDel = new RectDel(rect.GetArea);
            rectDel += rect.GetPerimeter;

            rectDel.Invoke(17.77, 40.22);

            Console.ReadKey();
        }
    }
}
