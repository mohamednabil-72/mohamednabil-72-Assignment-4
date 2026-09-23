using BenchmarkDotNet.Attributes;
using System.Text;

[MemoryDiagnoser]
public class StringBenchmark
{
    [Params(100, 1000, 10000, 100000)]
    public int Iterations;

    [Benchmark]
    public string StringConcatenation()
    {
        string result = "";
        string text = "Session\n";

        for (int i = 0; i < Iterations; i++)
        {
            result += text;
        }

        return result;
    }

    [Benchmark]
    public string StringBuilderConcatenation()
    {
        StringBuilder result = new StringBuilder();
        string text = "Session\n";

        for (int i = 0; i < Iterations; i++)
        {
            result.Append(text);
        }

        return result.ToString();
    }
}