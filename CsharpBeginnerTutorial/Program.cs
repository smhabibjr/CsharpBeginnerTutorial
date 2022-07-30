using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // user input and print that on terminal

            Console.WriteLine("Enter your user name ");
            string user_name =  Console.ReadLine();
            Console.WriteLine("Enter your age ");
            int user_age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your user name is " + user_name + " And You are " +  user_age + " Years old !");
        }
    }
}