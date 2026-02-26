using System.ComponentModel.Design;

namespace COMP003A.LectureActivity7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 85, 90, 78, 92, 88 };
            Console.WriteLine("Array Values: ");
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }

            List<string> names = new List<string>();
            names.Add("Alex");
            names.Add("Jordan");
            names.Add("Taylor");
            Console.WriteLine("\nNames:"); //using foreach
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nNames: "); //using for
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.Write("\nEnter a number between 1 and 3: ");
            string input = Console.ReadLine();
            bool theNumber = int.TryParse(input, out int validatedNumber);
            if (theNumber && validatedNumber >= 1 && validatedNumber <= 3)
            {
                Console.WriteLine("Valid number");
            }
            else
            {
                Console.WriteLine("Invalid number, please try again and pick between 1 and 3");
            }

            Console.Write("\nEnter another number: "); //using try-catch
            string input2 = Console.ReadLine();
            try
            {
                int choice = int.Parse(input2);
                if (choice >= 1 && choice <= 3)
                {
                    Console.WriteLine("Valid number");
                }
                else
                {
                    Console.WriteLine("Please try again, choose number between 1 and 3");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input, please actually choose a number between 1 and 3");
            }
            
            // Part F
            // 1. Input validation preferred over try-catch when possible it prevents errors before they happen.
            // It avoids unnecessary exceptions and keeps the program flow consistent.
            // 2. Try-catch still necessary in some cases because not all invalid inputs can be prevented.
            // and try-catch ensures the program not to crash.
            // 3. Debugging helped me understand loop behavior by showing how the loop variable changes each iteration
            // and how each array or list elements are accessed step by step.
        }
    }
}
