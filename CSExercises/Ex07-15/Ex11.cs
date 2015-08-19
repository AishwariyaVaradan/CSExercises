using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            double d, c;
            double f = 2.40;
            Console.WriteLine("Enter the distance covered");
            d = Convert.ToDouble(Console.ReadLine());
            c = 2.40 + d * 0.4;
            Console.WriteLine("The cost is:" + c);
        }
    }
}
