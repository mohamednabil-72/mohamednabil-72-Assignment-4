using BenchmarkDotNet.Running;

using System.Text;

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
            //Console.Write("Enter duration: ");
            //int duration = int.Parse(Console.ReadLine());

            //try
            //{
            //    ValidateDuration(duration);
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Input operation finished.");
            //}

            BenchmarkRunner.Run<StringBenchmark>();

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
        static DateTime GetSessionEndTime(DateTime startTime, int duration)
        {
            return startTime.AddMinutes(duration);
        }
        static DateTime ReadSessionDate()
        {
            Console.Write("Enter session date: ");
            return DateTime.Parse(Console.ReadLine());
        }
        static string BuildReportUsingString(
            string[] sessionNames,
            DateTime[] sessionDates,
            int[] sessionDurations)
        {
            string report = "";

            for (int i = 0; i < sessionNames.Length; i++)
            {
                report += $"{i + 1}. {sessionNames[i]}\n";
                report += $"Date: {sessionDates[i]:d MMMM yyyy}\n";
                report += $"Start Time: {sessionDates[i]:hh:mm tt}\n";
                report += $"Duration: {sessionDurations[i]} minutes\n";
                report += "\n";
            }

            return report;
        }
        static string BuildReportUsingStringBuilder(
    string[] sessionNames,
    DateTime[] sessionDates,
    int[] sessionDurations)
        {
            StringBuilder report = new StringBuilder();

            for (int i = 0; i < sessionNames.Length; i++)
            {
                report.AppendLine($"{i + 1}. {sessionNames[i]}");
                report.AppendLine($"Date: {sessionDates[i]:d MMMM yyyy}");
                report.AppendLine($"Start Time: {sessionDates[i]:hh:mm tt}");
                report.AppendLine($"Duration: {sessionDurations[i]} minutes");
                report.AppendLine();
            }

            return report.ToString();
        }
        static void changeValue(ref int num)
        {
            num = 19;
        }
        static bool GetSessionInfo(string sessionName, string[] sessionNames,int[] sessionDurations,out int index,out int duration)
        {
            index = Array.IndexOf(sessionNames, sessionName);
            if (index != -1)
            {
                duration = sessionDurations[index];
                return true;
            }
            duration = 0;
            return false;
        }
        static void ChangeArray(string[] names)
        {
            names[0] = "Changed";
        }
        static int CalculateTotalDuration(params int[] durations)
        {
            int total = 0;

            foreach (int duration in durations)
            {
                total += duration;
            }

            return total;
        }
        static void DisplaySessionDateDetails(string sessionName,DateTime sessionDate,int duration)
        
        {
            DateTime endTime = sessionDate.AddMinutes(duration);

            Console.WriteLine($"Session: {sessionName}");
            Console.WriteLine($"Date: {sessionDate:d MMMM yyyy}");
            Console.WriteLine($"Day: {sessionDate.DayOfWeek}");
            Console.WriteLine($"Year: {sessionDate.Year}");
            Console.WriteLine($"Month: {sessionDate.Month}");
            Console.WriteLine($"Day Number: {sessionDate.Day}");
            Console.WriteLine($"Start Time: {sessionDate:hh:mm tt}");
            Console.WriteLine($"Duration: {duration} minutes");
            Console.WriteLine($"End Time: {endTime:hh:mm tt}");
        }
        static void CalcaluteDateDifference(string[] sessionNames, DateTime[] sessionDates)
        {
            Console.WriteLine("Frist Session");
            string fristSession = Console.ReadLine();
            Console.WriteLine("Second Session");
            string secondSession = Console.ReadLine();
            int fristindex = Array.IndexOf(sessionNames, fristSession);
            int secondindex = Array.IndexOf(sessionNames, secondSession);
            TimeSpan difference = sessionDates[secondindex] - sessionDates[fristindex];
            Console.WriteLine();
            Console.WriteLine("Difference:");
            Console.WriteLine($"{difference.Days} days");
            Console.WriteLine($"{difference.TotalHours} hours");

        }
        static void DisplaySessionStatus( string[] sessionNames,DateTime[] sessionDates)

        {
            DateTime now = DateTime.Now;

            for (int i = 0; i < sessionNames.Length; i++)
            {
                if (sessionDates[i] < now)
                {
                    Console.WriteLine($"{sessionNames[i]} Past");
                }
                else
                {
                    Console.WriteLine($"{sessionNames[i]} Upcoming");
                }
            }
        }
        static void FindNextSession( string[] sessionNames,DateTime[] sessionDates)

        {
            DateTime now = DateTime.Now;

            int nextIndex = -1;
            DateTime nearestDate = DateTime.MaxValue;

            for (int i = 0; i < sessionDates.Length; i++)
            {
                if (sessionDates[i] > now && sessionDates[i] < nearestDate)
                {
                    nearestDate = sessionDates[i];
                    nextIndex = i;
                }
            }

            if (nextIndex == -1)
            {
                Console.WriteLine("No upcoming sessions.");
                return;
            }

            TimeSpan remaining = nearestDate - now;

            Console.WriteLine("Next Session:");
            Console.WriteLine();
            Console.WriteLine(sessionNames[nextIndex]);
            Console.WriteLine($"{nearestDate:d MMMM yyyy}");
            Console.WriteLine($"{nearestDate:hh:mm tt}");

            Console.WriteLine();
            Console.WriteLine("Time Remaining:");
            Console.WriteLine($"{remaining.Days} days");
            Console.WriteLine($"{remaining.Hours} hours");
        }
        static void DisplayDateFormats(DateTime sessionDate)
        {
            Console.WriteLine(sessionDate.ToString("yyyy-MM-dd"));
            Console.WriteLine(sessionDate.ToString("dd/MM/yyyy"));
            Console.WriteLine(sessionDate.ToString("dd MMMM yyyy"));
            Console.WriteLine(sessionDate.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(sessionDate.ToString("hh:mm tt"));
        }
        static DateTime ReadValidDate()
        {
            while (true)
            {
                Console.Write("Enter date (yyyy-MM-dd HH:mm): ");
                string input = Console.ReadLine();

                if (DateTime.TryParseExact(
                    input,
                    "yyyy-MM-dd HH:mm",
                    null,
                    System.Globalization.DateTimeStyles.None,
                    out DateTime date))
                {
                    return date;
                }

                Console.WriteLine("Invalid date. Please try again.");
            }
        }
        static int ReadMenuOption()
        {
            while (true)
            {
                Console.Write("Choose an option: ");
                string input = Console.ReadLine();

                try
                {
                    return int.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid menu option. Enter a number.");
                }
            }
        }
        static void AccessSessionByIndex(string[] sessionNames)
        {
            Console.Write("Enter session index: ");
            int index = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine($"Session: {sessionNames[index]}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("The selected session index is out of range.");
            }
        }
        static void ValidateDuration(int duration)
        {
            if (duration <= 0)
            {
                throw new ArgumentException("Duration must be greater than zero.");
            }

            Console.WriteLine("Duration accepted.");
        }
        static string BuildScheduleReport( string[] sessionNames, DateTime[] sessionDates  ,int[] sessionDurations)

        {
            string result = "";

            for (int i = 0; i < sessionNames.Length; i++)
            {
                result += $"{sessionNames[i]} - ";
                result += $"{sessionDates[i]:dd/MM/yyyy hh:mm tt} - ";
                result += $"{sessionDurations[i]} minutes";
                result += "\n";
            }

            return result;
        }
        static string BuildScheduleReportUsingStringBuilder(string[] sessionNames, DateTime[] sessionDates, int[] sessionDurations)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < sessionNames.Length; i++)
            {
                result.Append($"{sessionNames[i]} - ");
                result.Append($"{sessionDates[i]:dd/MM/yyyy hh:mm tt} - ");
                result.Append($"{sessionDurations[i]} minutes");
                result.AppendLine();
            }

            return result.ToString();
        }

    }
}
