using System.Text;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int iteration = 10000;

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        for (int i = 0; i < iteration; i++)
        {
            sb.Append("Hello");
            sb.Append("World");
        }
        stopwatch.Stop();

        Console.WriteLine(stopwatch.ElapsedMilliseconds);
    }
}