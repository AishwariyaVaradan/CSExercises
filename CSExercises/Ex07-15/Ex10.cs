using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            double x1,x2,y1,y2,d,X,Y;
            Console.WriteLine("Enter the value of x1");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the x2 value");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y1");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y2");
            y2 = Convert.ToDouble(Console.ReadLine());
            X=(x2 - x1) * (x2 - x1) ;
            Y=(y2 - y1) * (y2 - y1);
            d= System.Math.Sqrt(X+Y);
            Console.WriteLine("The output is:"+d);
        }
    }
}
