using System;

namespace myApp
{
    class Program
    {
        static string fizzbuzz(int number){
            string output;
            if (number % 15 == 0) {
                output = "fizzbuzz";
            } else if (number % 3 == 0) {                
                output = "fizz";
            } else if (number % 5 == 0) {
                output = "buzz";
            } else {
                output = number.ToString();
            }

            return output;
        }
        
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter number:");
            string n = Console.ReadLine();            

            for (int i = 1; i <= Convert.ToInt16(n); i++){
                Console.WriteLine(fizzbuzz(i));
            }            
        }
    }
}
