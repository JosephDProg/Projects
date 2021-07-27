using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Starting task to write Hello World to the console to confirm everything is working
            Console.WriteLine("Hello World!");
            Console.WriteLine("Work across both platforms");
            //End starting task

            //First Challenge to write the FizzBuzz test to get familliar with loops
            for(int i=1;i<=100;i++){
                if(i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");
                else
                if(i % 3 == 0)
                Console.WriteLine("Fizz");
                else
                if(i % 5 == 0)
                Console.WriteLine("Buzz");
                else
                Console.WriteLine(i);
            }
            //End FizzBuzz challenge

        

        }
    }
}
