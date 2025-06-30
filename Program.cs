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

            #region Q3
            //Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            int num1 = 5, num2 = 6;
            int summation = num1 + num2;
            int substraction;
            if (num1 > num2) substraction = num1 - num2;
            else substraction = num2 - num1;
            int multiplication = num1 * num2;
            double division = num1 / num2;
            #endregion

            #region Q4
            //4-	Write C# program that Extract a substring from a given string.

            string originalstring = "abcdefg";
            string substring1 = originalstring.Substring(2, 3); // result = cde
            #endregion

            #region Q5
            //5-	Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            int x1 = 5;
            int y1;
            y1 = x1;
            x1 = 88;
            //result : y takes the old value of x but x now has new value replaced by the old 

            #endregion
        }
    }
}