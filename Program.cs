namespace Day03_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Write a program that allows the user to enter a number then print it.
            Console.WriteLine("Enter a number.");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine($"You have intered {s}");
            #endregion

            #region Q2
            //Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen
            Console.WriteLine("Enter a number.");
            int NUM = int.Parse(Console.ReadLine());
            //it will give me exception error :The input string was not in a correct format.
            #endregion
        }
    }
}