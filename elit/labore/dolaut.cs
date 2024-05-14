using System;

class Program
{
    static void Main()
    {
        // Initialize a variable to store the user's name
        string name = "";

        // Prompt the user for their name
        Console.Write("Please enter your name: ");
        name = Console.ReadLine();

        // Check if the user has entered a name
        if (!string.IsNullOrEmpty(name))
        {
            // Greet the user by name
            Console.WriteLine($"Hello, {name}!");
        }
        else
        {
            // If no name was entered, use a default greeting
            Console.WriteLine("Hello, stranger!");
        }
    }
}
