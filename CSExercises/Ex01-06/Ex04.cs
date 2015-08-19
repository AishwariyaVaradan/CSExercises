using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
           
          double   x = Convert.ToDouble(Console.ReadLine());
           Double sqrt1 = System.Math.Sqrt(x);
            Console.WriteLine("squareroot of x is :" + sqrt1);
        }
    }
}
