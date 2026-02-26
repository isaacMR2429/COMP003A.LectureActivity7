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
            Console.WriteLine("\nNames:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
