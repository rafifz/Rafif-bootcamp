internal class Program
{
	private static void Main(string[] args)
	{
		int a = 3;
		System.Console.WriteLine(a);
		Adder(a);
		System.Console.WriteLine(a);
		
		System.Console.WriteLine("using ref");
		int b = 3;
		System.Console.WriteLine(b);
		Adder(ref b);
		System.Console.WriteLine(b);
		
		System.Console.WriteLine("using in");
		int c = 3;
		System.Console.WriteLine(c);
		AdderIn(in c);
		System.Console.WriteLine(c);
		
		System.Console.WriteLine("using out");
		int d = 3;
		System.Console.WriteLine(d);
		AdderOut(out d);
		System.Console.WriteLine(d);
		
	}
	public static void Adder(int a)
	{
		a += 3;
	}
	public static void Adder(ref int a)
	{
		a += 3;
	}
	public static void AdderIn(in int a)
	{
		int result = a + 3;
	}
	public static void AdderOut(out int a)
	{
		a =3;
	}
	
}
