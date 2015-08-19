using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature in degree centigrade");
            double x, y;
            x = Convert.ToDouble(Console.ReadLine());
            y = 1.8 * x + 32;
            Console.WriteLine("The temperature in Farenheit is:" + y);
        }
    }
}
