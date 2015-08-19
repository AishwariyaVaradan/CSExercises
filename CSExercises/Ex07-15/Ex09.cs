using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Enter the x value");
            x = Convert.ToDouble(Console.ReadLine());
            y = 2 * (x * x) - (4 * x) + 3;
            Console.WriteLine("The output is:" + y);
        }
    }
}
