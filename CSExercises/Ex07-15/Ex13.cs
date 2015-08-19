using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The Performance of every student");
            double marks;
            Console.WriteLine("enter the marks of the student");
            marks = Convert.ToDouble(Console.ReadLine());
            if(marks>=80&& marks<=100)
            {
                Console.WriteLine("The grade  is A!! ");
            }
                else if(marks>=60&& marks<=79)
                {
                    Console.WriteLine("The grade is B!!");
                }
                else if(marks>=40&& marks<=59)
               {
                    Console.WriteLine("The grade is C!!");
               }
                else if(marks<=40&& marks>=0)
                {
                    Console.WriteLine("The grade is F!!");
                }
                else if(marks<0&&marks>100)
               { 
                    Console.WriteLine("Error!!!");
               }
            Console.WriteLine("Thank you!!!");
        }
    }
}
