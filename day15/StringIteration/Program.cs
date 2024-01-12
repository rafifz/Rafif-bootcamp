using System.Diagnostics;

internal class Program
{
	private static void Main(string[] args)
	{
		string hello = string.Empty;
		int iteration = 10000;
		Stopwatch stopwatch = new();
		stopwatch.Start();
		for (int i = 0; i < iteration; i++)
		{
			hello += "hello";
			hello += "world";
		}
		stopwatch.Stop();
		System.Console.WriteLine(stopwatch.ElapsedMilliseconds);
	}
}