internal class Program
{
	private static void Main(string[] args)
	{
		int a = 3;
		System.Console.WriteLine(a);
		Adder(a);
		System.Console.WriteLine(a); //will still 3
		
		
		System.Console.WriteLine("using ref");
		int b = 3;
		System.Console.WriteLine(b);
		Adder(ref b);
		System.Console.WriteLine(b); //output changed to 300 by method
		
		
		System.Console.WriteLine("using in");
		int c = 3;
		System.Console.WriteLine(c);
		AdderIn(in c);
		System.Console.WriteLine(c); //will still 3, passed as a reference but method cannot change
		
		
		System.Console.WriteLine("using out");
		int d;
		AdderOut(out d); 
		System.Console.WriteLine(d); //output : 300, asigned by the method
		
	}
	public static void Adder(int a)
	{
		a = 300; 
	}
	public static void Adder(ref int a)
	{
		a = 300;
	}
	public static void AdderIn(in int a)
	{
		// a = 300;
		// allow you to pass a reference to the argument but prevent the method from changing the reference, this will cause error
	}
	public static void AdderOut(out int a)
	{
		a = 300;
		//The parameter out guarantees that the argument will be assigned a value before the method returns.
	}
	
}
