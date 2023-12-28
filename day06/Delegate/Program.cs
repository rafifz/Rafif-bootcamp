using System;
public class Program
{
	public delegate int MyDelegate (int x, int y);
	public static void Main(string[] args)
	{
		MyDelegate myDelegate = Add;
		myDelegate += Multiply;
		int result = myDelegate(5, 5);;
		Console.WriteLine("5, 5 = " + result);
	}

	public static int Multiply(int x, int y)
	{
		return x * y;
	}
	public static int Add(int x, int y)
	{
		return x + y;
	}
}