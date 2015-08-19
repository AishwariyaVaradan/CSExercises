using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please enter thge number");
            double y, x;
            x = Convert.ToDouble(Console.ReadLine());
            y = x * x;
            Console.WriteLine("the square of the input number is :" + x * x);
        }
    }
}
