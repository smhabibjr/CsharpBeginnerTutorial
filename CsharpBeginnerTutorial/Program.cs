using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            int myNum = 5;               // Integer (whole number)
            double myDoubleNum = 5.99D;  // Floating point number
            char myLetter = 'D';         // Character
            bool myBool = true;          // Boolean
            string myText = "Hello";     // String

            //Implicit Casting
            // char > int > lang > float > double
            double myDouble = myNum;
            Console.WriteLine("Implicit casting " + myDouble.GetType());

            //Type Conversion Methods
            string convert_int_to_string = Convert.ToString(myNum);
            // more conversion methods 
            Console.WriteLine(Convert.ToString(myNum));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myNum));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myNum));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));
            Console.WriteLine("Type Conversion" + convert_int_to_string.GetType());
        }
    }
}