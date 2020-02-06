using System;

namespace PG_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please eneter your Name: ");
            // reads the input and assigns it to a string called name
            string name = Console.ReadLine();
            // Checks if the field entered is empty
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("The name field could not be empty. Please try again.");
            }
            else
            {
                // This command displays the concatinated result of the user input and the hello + !
                Console.WriteLine(Concatinating_Name(name));
            }
        }
        // This static value return method returns a concatination of the user input with the hello and !
        private static string Concatinating_Name(string input)
        {
            string name = ("Hello " + input + "!");
            return name;
        }
    }
}
