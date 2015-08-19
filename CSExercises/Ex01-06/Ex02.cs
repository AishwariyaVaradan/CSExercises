using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the integer");
            Console.WriteLine("output will be its square");
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("square of the number is : " + x * x);
        }
    }
}
