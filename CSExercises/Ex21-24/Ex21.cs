using System;
namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            
            int i = Convert.ToInt32(Console.ReadLine());
            while (i != 88)
            {             
            
            
                Console.WriteLine("enter a number");
                i = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Lucky you..");
            Console.Read();
            
        }
    }
}
