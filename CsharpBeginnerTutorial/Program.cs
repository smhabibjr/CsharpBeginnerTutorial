using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int loop_number = Convert.ToInt32(Console.ReadLine());
            // while loop
            int initial_value = loop_number; 
            while(initial_value > 0)
            {
                int myNum = initial_value - 1;

                Console.WriteLine("This is a while loop " + myNum);
                initial_value--;
            }
            Console.WriteLine("Enter your 2nd number ");
            int for_loop = Convert.ToInt32(Console.ReadLine());

            // for loop
            for(int i = 0; i < for_loop; i++)
            {
                Console.WriteLine("this is for loop " + i);

            }

            // forEach loop

            string[] names = { "Habib", "Abdul Khalek", "A.Malek", "Alem" };
            
            foreach(string name in names)
            {
                Console.WriteLine("For each loop" + name);

            }

        }
    }
}