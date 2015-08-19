using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("ABC Company employees details");
            double h,t,sl;
           /* s=Convert.ToDouble(Console.ReadLine());
            t=Convert.ToDouble32(Console.ReadLine());
            h=Convert.ToDouble32(Console.ReadLine());
            sl = Convert.ToDouble32(Console.ReadLine());*/
            Console.WriteLine("Enter the employee salary");
             double s =Convert.ToDouble( Console.ReadLine());
            h = 0.1 * s;
            t = 0.03 * s;
            sl = s + h + t;
            Console.WriteLine("The toatal salary of the employee is:" + sl);
        }
    }
}
