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
            Console.WriteLine("\nNames (using foreach):");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nNames (using for): ");
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
        }
    }
}
