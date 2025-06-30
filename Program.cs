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
        }
    }
}