using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
   public class StringBenchmark
    {
        [Benchmark]
        public string StringConcatenation()
        {
            string result = "";

            for (int i = 0; i < 100; i++)
            {
                result += "Session " + i + "\n";
            }

            return result;
        }

        [Benchmark]
        public string StringBuilderConcatenation()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                result.Append("Session ");
                result.Append(i);
                result.AppendLine();
            }

            return result.ToString();
        }
    }
}
