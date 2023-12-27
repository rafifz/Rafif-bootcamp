using System;
public class Program
{
	public delegate int Delegate (int x, int y);
	public static void Main(string[] args)
	{
		Delegate myDelegate = Plus;
		myDelegate += Multiply;
		int result = myDelegate(5, 5);
		int[] myResult = new int[2];
		Console.WriteLine("5, 5 = " + result);
	}

	public static int Multiply(int x, int y)
	{
		return x * y;
	}
	public static int Plus(int x, int y)
	{
		return x + y;
	}
}