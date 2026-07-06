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
        
        //Task 5 - Grade Rounding System

        Console.Write("Enter your raw exam score: ");
        double rawScore = Convert.ToDouble(Console.ReadLine());

        double roundedScore = Math.Round(rawScore);

        Console.WriteLine("Your rounded score is: " + roundedScore);

        if (roundedScore >= 60)
        {
            Console.WriteLine("Result: Pass");
        }
        else
        {
            Console.WriteLine("Result: Fail");
        }
        
        //Task 6 - Password Strength Checker

        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        bool isLongEnough = password.Length >= 8;

        bool containsForbiddenWord = password.ToLower().Contains("password");

        if (isLongEnough && !containsForbiddenWord)
        {
            Console.WriteLine("Strong: The password meets all requirements.");
        }
        else
        {
            Console.WriteLine("Weak: The password is either too short or contains the forbidden word.");
        }

        //Task 7 - Clean Name Comparator
        

        Console.Write("Enter the first name: ");
        string name1 = Console.ReadLine();

        Console.Write("Enter the name again: ");
        string name2 = Console.ReadLine();

        string cleanName1 = name1.Trim().ToLower();
        string cleanName2 = name2.Trim().ToLower();

        if (cleanName1 == cleanName2)
        {
            Console.WriteLine("Match");
        }
        else
        {
            Console.WriteLine("No Match");
        }
        
        //Task 8 - Membership Expiry Checker
        
        try
        {
            Console.Write("Enter membership start date (yyyy-mm-dd): ");
            string dateInput = Console.ReadLine();
            
            Console.Write("Enter the number of valid membership days: ");
            int daysValid = Convert.ToInt32(Console.ReadLine());

            DateTime startDate = DateTime.Parse(dateInput);

            DateTime expiryDate = startDate.AddDays(daysValid);

            if (expiryDate >= DateTime.Today)
            {
                Console.WriteLine("Status: Active");
            }
            else
            {
                Console.WriteLine("Status: Expired");
            }

            Console.WriteLine("Expiry Date: " + expiryDate.ToString("yyyy-MM-dd"));
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter the date in the correct format (yyyy-mm-dd).");
        }
        
        //Task 9 - Round Up / Round Down Explorer

        
        Console.Write("Please enter a decimal number: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double Number))
        {
            double rounded = Math.Round(Number);

            double ceiling = Math.Ceiling(Number);

            double floor = Math.Floor(Number);

            Console.WriteLine("\n--- Rounding Results ---");
            Console.WriteLine($"Original Number: {Number}");
            Console.WriteLine($"Nearest Whole Number (Math.Round): {rounded}");
            Console.WriteLine($"Always Rounded Up (Math.Ceiling): {ceiling}");
            Console.WriteLine($"Always Rounded Down (Math.Floor):  {floor}");
        }
        else
        {
            Console.WriteLine("Error: Please enter a valid decimal number.");
        }
        
        //Task 10 - Word Position Finder

        Console.Write("Enter a full sentence: ");
        string sentence = Console.ReadLine();

        Console.Write("Enter a word to search for: ");
        string word = Console.ReadLine();

        int firstIndex = sentence.IndexOf(word);
        
        int lastIndex = sentence.LastIndexOf(word);

        Console.WriteLine("\n--- Search Results ---");
        
        if (firstIndex == -1)
        {
            Console.WriteLine($"The word '{word}' was not found in the sentence.");
        }
        else
        {
            Console.WriteLine($"First occurrence of '{word}' is at index: {firstIndex}");
            Console.WriteLine($"Last occurrence of '{word}' is at index:  {lastIndex}");
        }
        
        //Task 11 - One-Time Password (OTP) Generator

                // Generate a random 4-digit code between 1000 and 9999
        Random rnd = new Random();
        int otp = rnd.Next(1000, 10000);

        Console.WriteLine($"Your OTP is: {otp}");
        Console.WriteLine("Please enter the code to verify:");

        int attempts = 0;
        bool isVerified = false;

                // Give the user up to 3 attempts
        while (attempts < 3)
        {
            try
            { int Input = int.Parse(Console.ReadLine());
                if (Input == otp)
                {
                    Console.WriteLine("Verified");
                    isVerified = true;
                    break;
                }
                else
                {
                    attempts++;
                    Console.WriteLine($"Verification Failed. Attempts left: {3 - attempts}");
                }
            }
            catch (FormatException)
            {
                        // Handle non-numeric input
                attempts++;
                Console.WriteLine($"Invalid input. Please enter a number. Attempts left: {3 - attempts}");
            }
        }

        if (!isVerified)
        {
            Console.WriteLine("Maximum attempts reached. Access denied.");
        }



    }
}
