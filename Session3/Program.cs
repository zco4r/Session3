namespace Session3;

class Program
{
    static void Main()
    {
       //Task 1 - Absolute Difference 
        
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double difference = num1 - num2;

        double absoluteDifference = Math.Abs(difference);

        Console.WriteLine("The absolute difference is: " + absoluteDifference);
        
        //Task 2 - Power & Root Explorer

        Console.Write("Enter a number: ");
        double number = Convert.ToDouble(Console.ReadLine());

        double square = Math.Pow(number, 2);

        double squareRoot = Math.Sqrt(number);

        Console.WriteLine("The square of the number is: " + square);
        Console.WriteLine("The square root of the number is: " + squareRoot);
        
        //Task 3 - Name Formatter

        Console.Write("Enter your full name: ");
        string fullName = Console.ReadLine();

        string upperName = fullName.ToUpper();

        string lowerName = fullName.ToLower();

        int characterCount = fullName.Length;

        Console.WriteLine("Uppercase: " + upperName);
        Console.WriteLine("Lowercase: " + lowerName);
        Console.WriteLine("Character count: " + characterCount);
        
        //Task 4 - Subscription End Date
        

        Console.Write("Enter the number of days for the free trial: ");
        int trialDays = Convert.ToInt32(Console.ReadLine());

        DateTime today = DateTime.Today;

            DateTime endDate = today.AddDays(trialDays);

        Console.WriteLine("Your trial will end on: " + endDate.ToString("yyyy-MM-dd"));



    }
}
