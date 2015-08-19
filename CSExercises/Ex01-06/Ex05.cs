using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the number");  //* entering the value of the number whose square root must be found*//
            double x, y;      //*initialising the input and ouptut values*//
            x = Convert.ToDouble(Console.ReadLine());  //* initialising the compiler to accept the varying input values*//
            y = System.Math.Sqrt(x);   //* finding the square root of x and storing it in y*//
            Console.WriteLine("square root of x is {1:0.000}", x, y); //*printing the output y*//
        }
    }
}
