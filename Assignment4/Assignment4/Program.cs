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
        static void searchForSession(string[] sessionNames, DateTime[] sessionDates, int[] sessionDurations)
        {
            Console.WriteLine("Enter a Session name");
            string searchName = Console.ReadLine();
            int index = Array.IndexOf(sessionNames, searchName);
            if (index != -1)
            {
                Console.WriteLine($"Name :{sessionNames[index]}");
                Console.WriteLine($"Date: {sessionDates[index]:d MMMM yyyy}");
                Console.WriteLine($"Start Time: {sessionDates[index]:hh:mm tt}");
                Console.WriteLine($"Duration: {sessionDurations[index]}minutes");
                Console.WriteLine();
            }
            else
                Console.WriteLine("Session not found.");
        }
        static void SortArrayMethod(string[] sessionNames)
        {
            string[] copy = new string[sessionNames.Length];
            Array.Copy(sessionNames, copy, sessionNames.Length);
            Array.Sort(copy);
            foreach(string name in copy)
            {
                Console.WriteLine(name);
            }

        }
        static void ReverseSessionNames(string[] sessionNames)
        {
            string[] copy = new string[sessionNames.Length];

            Array.Copy(sessionNames, copy, sessionNames.Length);

            Array.Reverse(copy);

            foreach (string name in copy)
            {
                Console.WriteLine(name);
            }
        }
        static void FindSessionIndex(string[] sessionNames)
        {
            Console.Write("Enter session name: ");
            string searchName = Console.ReadLine();

            int index = Array.IndexOf(sessionNames, searchName);

            Console.WriteLine($"Index: {index}");
        }
        static void CheckSessionExists(string[] sessionNames)
        {
            Console.WriteLine("Enter a session name");
            string searchName = Console.ReadLine();
            bool IsExist = Array.Exists(sessionNames, name => name == searchName);
            if (IsExist)
            {
                Console.WriteLine("Session exists.");
            }
            else
            {
                Console.WriteLine("Session does not exist.");
            }
        }
        static void FindSession(string[] sessionNames)
        {
            string session = Array.Find(sessionNames, name => name.StartsWith("A"));

            Console.WriteLine(session);
        }
        static void FindSessionIndexUsingCondition(string[] sessionNames)
        {
            int index = Array.FindIndex(sessionNames, name => name.StartsWith("A"));

            Console.WriteLine($"Index: {index}");
        }
        static void CopySessionNames(string[] sessionNames)
        {
            string[] copy = new string[sessionNames.Length];

            Array.Copy(sessionNames, copy, sessionNames.Length);

            copy[0] = "Changed Session";

            Console.WriteLine("Original array:");

            foreach (string name in sessionNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            Console.WriteLine("Copied array:");

            foreach (string name in copy)
            {
                Console.WriteLine(name);
            }
        }
        static void AnalyzeDurations(int[] sessionDurations)
        {
            int total = 0;
            int shortest = sessionDurations[0];
            int longest = sessionDurations[0];

            foreach (int duration in sessionDurations)
            {
                total += duration;

                if (duration < shortest)
                {
                    shortest = duration;
                }

                if (duration > longest)
                {
                    longest = duration;
                }
            }

            double average = (double)total / sessionDurations.Length;

            Console.WriteLine($"Total Duration: {total} minutes");
            Console.WriteLine($"Average Duration: {average} minutes");
            Console.WriteLine($"Shortest Duration: {shortest} minutes");
            Console.WriteLine($"Longest Duration: {longest} minutes");
        }
    }
}
