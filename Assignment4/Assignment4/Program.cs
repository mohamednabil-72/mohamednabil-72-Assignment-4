using System.Security.Cryptography.X509Certificates;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sessionNames =
             {
                "C# Basics",
                "Arrays",
                "Functions",
                "Date and Time",
                "Exception Handling"
            };
            DateTime[] sessionDates =
            {
                new DateTime(2026, 9, 12, 18, 0, 0),
                new DateTime(2026, 9, 13, 18, 0, 0),
                new DateTime(2026, 9, 17, 18, 0, 0),
                new DateTime(2026, 9, 20, 18, 0, 0),
                new DateTime(2026, 9, 24, 18, 0, 0)
            };
            int[] sessionDurations =
            {
                180,
                240,
                180,
                240,
                180
            };
           
           
            Display(sessionNames, sessionDates, sessionDurations);


        }
        static void Display(string[] sessionNames, DateTime[] sessionDates, int[] sessionDurations)
        {
            for (int i = 0; i < sessionNames.Length; i++)
            {
                Console.WriteLine($"{i + 1}.{sessionNames[i]}");
                Console.WriteLine($"Date: {sessionDates[i]:d MMMM yyyy}");
                Console.WriteLine($"Start Time: {sessionDates[i]:hh:mm tt}");
                Console.WriteLine($"Duration: {sessionDurations[i]}minutes");
                Console.WriteLine();
            }
        }
    }
}
