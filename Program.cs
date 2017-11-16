using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 100;
            int i = 1;

            while (i <= Number) {
                Console.WriteLine(i % 3 == 0 && i % 5 == 0 /*i % 15 == 0*/? "FizzBuzz": (i % 3 == 0 ? " Fizz": (i % 5 == 0 ? " Buzz":(i + ""))));
                /*if (i % 3 == 0 && i % 5 == 0){
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 3 == 0 ){
                    Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0){
                    Console.WriteLine("Buzz");
                }
                else {
                Console.WriteLine(i);
                }*/
                i++;
                }
        }
    }
}
