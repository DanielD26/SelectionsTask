  
using System;

namespace Selections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.WriteLine("Enter age: ");
            string age = Console.ReadLine();

            int ageNum = int.Parse(age);

            if (ageNum > 17) {
                Console.WriteLine("Legally adult age: ");          
            } else {
                Console.WriteLine("Legally not adult age");
            }
            //Task 2 
            Console.WriteLine("Please enter age: ");
            if (ageNum > 17) {

                Console.Write("Please enter your gender: ");
                string gender = Console.ReadLine();

                if (gender == "M") {
                    Console.WriteLine("M is an adult");
                } else if (gender == "F"){
                    Console.WriteLine("F is an adult");
                } else {
                    Console.WriteLine("Please enter M or F");
                }
            } else {
                Console.WriteLine("Legally not adult age");
            }
            //Task 3
            
            Console.WriteLine("Please enter a number: ");
            string numOne = Console.ReadLine();
            Console.WriteLine("Please enter another number: ");
            string numTwo = Console.ReadLine();

            int numOneResult = int.Parse(numOne);
            int numTwoResult = int.Parse(numTwo);

            if (numOneResult + numTwoResult > 10) {
                Console.WriteLine("Sum of numbers is greater than 10");
            } else {
                Console.WriteLine("Sum of numbers is less than 10");
            }
        }
    }
}