namespace LAB_04
{
    internal class Program
    {
        // Zadanie 3
        static double Multiply(double a, double b)
        {
            return a * b;
        }
        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
        static double Multiply(params double[] numbers)
        {
            double result = 1.0;
            foreach (var number in numbers)
            {
                result *= number;
            }
            return result;
        }

        //Zadanie 4
        enum DayOfTheWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void DisplayDayInfo(DayOfTheWeek day)
        {
            Console.WriteLine($"Dzień tygodnia: {day} ({(int)day})");
            if (day == DayOfTheWeek.Saturday || day == DayOfTheWeek.Sunday)
            {
                Console.WriteLine("To jest weekend.");
            }
            else
            {
                Console.WriteLine("To jest dzień roboczy.");
            }
        }
        //Zadanie 5
        static string FormatDateTime(DateTime date)
        {
            return $"DZIEŃ: {date.Day}, MIESIĄC: {date.Month}, ROK: {date.Year}," +
                $" GODZINA: {date.Hour}, MINUTA: {date.Minute}, SEKUNDA: {date.Second}, " +
                $" DZIEŃ TYGODNIA: {date.DayOfWeek}";
        }

        static void Main(string[] args)
        {
            //Zadanie 1
            double QuadraticEquation(double x = 0.0, double a = 1.0, double b = 1.0, double c = 1.0)
            {
                return a * x * x + b * x + c;
            }
            Console.WriteLine(QuadraticEquation());

            //Zadanie 2
            void Swap(ref double a, ref double b)
            {
                double temp = a;
                a = b;
                b = temp;
            }
            double x = 10;
            double y = 20;
            Swap(ref x, ref y);
            Console.WriteLine($"x = {x}, y = {y}");

            //Zadanie 4
            DisplayDayInfo(DayOfTheWeek.Monday);

            //Zadanie 5
            DateTime date = DateTime.Now;
            Console.WriteLine(FormatDateTime(date));

            //Zadanie 6
            try
            {
                double Divide(double a, double b)
                {
                    return a / b;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Zadanie 7

            try
            {
                Console.WriteLine("Enter a new password:");
                string password = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(password))
                {
                    throw new ArgumentException("Password cannot be empty.");
                }

                if (password.Length < 10)
                {
                    throw new FormatException("Password must be at least 10 characters long.");
                }

                bool hasUpperCase = false;
                bool hasLowerCase = false;
                bool hasDigit = false;
                bool hasSpecialChar = false;

                foreach (char c in password)
                {
                    if (char.IsUpper(c)) hasUpperCase = true;
                    if (char.IsLower(c)) hasLowerCase = true;
                    if (char.IsDigit(c)) hasDigit = true;
                    if (!char.IsLetterOrDigit(c)) hasSpecialChar = true;
                }

                if (!hasUpperCase)
                {
                    throw new FormatException("Password must contain an uppercase letter.");
                }
                if (!hasLowerCase)
                {
                    throw new FormatException("Password must contain a lowercase letter.");
                }
                if (!hasDigit)
                {
                    throw new FormatException("Password must contain a digit.");
                }
                if (!hasSpecialChar)
                {
                    throw new FormatException("Password must contain a special character.");
                }

                Console.WriteLine("Password has been successfully set.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}

