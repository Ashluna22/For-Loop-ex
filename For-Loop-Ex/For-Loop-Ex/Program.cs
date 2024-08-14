using System;







namespace For_Loop_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                bool continueProgram = true;

                while (continueProgram)
                {
                    Console.Write("Enter a number: ");
                    int number = int.Parse(Console.ReadLine());

                    for (int i = number; i >= 0; i--)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();

                    for (int i = 0; i <= number; i++)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();

                    Console.Write("Would you like to continue (y/n)? ");
                    string response = Console.ReadLine().ToLower();

                    if (response != "y")
                    {
                        continueProgram = false;
                        Console.WriteLine("Goodbye!");
                    }
                }
            }
        }
    }
}