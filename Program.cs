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

            #region Q6
            //6-	Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            point p1 = new point(1, 2);
            point p2;
            p2 = p1;
            p1 = new point(2, 3);
            //result : p1 refers to new coordinates but p2 refers to the old coordinates 
            #endregion

            #region Q7
            //7 - Write C# program that take two string variables and print them as one variable 
            Console.WriteLine("enter Your First Name ");
            string fn = Console.ReadLine();
            Console.WriteLine("enter Your Last Name ");
            string ln = Console.ReadLine();
            Console.WriteLine(" ____________________\n");
            string fullname = fn + " " + ln;
            Console.WriteLine($"then your Full name : {fullname}");
            #endregion

            #region Q8
            //8-	Write a program that calculates the simple interest given the principal amount, rate of interest, and time.The formula for simple interest is //Interest = (principal * rate * time) / 100.
            int principalamount = 10000;
            int interestrate = 25;
            int period = 1;

            double Interest = (principalamount * interestrate * period) / 100;
            #endregion

            #region Q9
            //9-	Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters.The formula for BMI isBMI = (Weight) / (Height * Height)
            double height = 190 / 100d;
            double weigth = 85;
            double BMI = weigth / (height * height);
            #endregion

            #region Q10
            //10-	Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good".
            double temperature = 25;
            string result;
            if (temperature < 10) result = "Just Cold";
            else if (temperature > 30) result = "Just Hot";
            else result = "Just Good";
            #endregion

            #region Q11
            //11-	Write a program that takes the date from the user and displays it in various formats using string interpolation.
            //Ex:
            //Today’s date : 20 , 11 , 2001
            //Today's date : 20 / 11 / 2001
            //Today's date : 20 – 11 – 2001

            Console.WriteLine("I want Today Date in numbers :\n");
            Console.WriteLine("what is the day num");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("what is the month num");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("what is the year num");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("________________________\n");
            Console.WriteLine("then fulldate can be written as : ");
            Console.WriteLine($"{day} , {month} , {year}");
            Console.WriteLine($"{day} / {month} / {year}");
            Console.WriteLine($"{day} - {month} - {year}");
            #endregion

            #region Q12
            //12- What is the output of the following C# code?
            //DateTime date = new DateTime(2024, 6, 14); Console.WriteLine($"The event is on {date:MM/dd/yyyy}");

            string choice = "c) The event is on 06/14/2024";
            #endregion

            #region Q13
            //13-	Which of the following statements is correct about the C#.NET code snippet given below?
            //int d; 
            // d = Convert.ToInt32(!(30 < 20));

            choice = "f)	A value 1 will be assigned to d.";
            #endregion

            #region Q14
            //14-	Which of the following is the correct output for the C# code given below?
            //Console.WriteLine(13 / 2 + " " + 13 % 2); 

            choice = "d)6 1";
            #endregion


        }
    }
    class point
    {
        public int xx;
        public int yy;
        public point(int x, int y)
        {
            xx = x; yy = y;
        }
        public override string ToString()
        {
            return $"x={xx} , y={yy}";
        }
    }

}