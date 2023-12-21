using System.Diagnostics;
using System.Text;

internal class Program
{
	private static void Main(string[] args)
	{
		int iteration = 100000;
		string a = string.Empty;
		Stopwatch sw = new Stopwatch();
		
		//string is immutable reference type, when assigned its create new allocate memory, so will take a long time
		/*
		sw.Start();
		for (int i = 0; i < iteration; i++)
		{
			//
			a += "a";
			a += "b";
			a += "c";
		}
		sw.Stop();
		System.Console.WriteLine($"it takes {sw.ElapsedMilliseconds} miliseconds");
		*/
		
		//when using StringBuilder, it doesnot create new allocate memory, rather replacing it, its faster
		StringBuilder b = new StringBuilder();
		sw.Start();
		for (int i = 0; i < iteration; i++)
		{
			//
			b.Append("a");
			b.Append("b");
			b.Append("c");
		}
		sw.Stop();
		System.Console.WriteLine($"it takes {sw.ElapsedMilliseconds} miliseconds");
		
		//example of value type
		System.Console.WriteLine("console value");
		int x = 5;
		Adder(x);
		System.Console.WriteLine(x); //will return 5 
		
		int u = 5;
		u = Adder(u);
		System.Console.WriteLine(u); //will return 8
		
		//=======================
		
		//example of reference type
		System.Console.WriteLine("console reference");
		Car small = new(5);
		Car big = small;
		big.price = 10;
		
		System.Console.WriteLine(small.price); //will return 10 because reference type, big car rewrite the allocate memory to 10
		System.Console.WriteLine(big.price);
	}
	
	public static int Adder(int a)
	{
		return  a += 3;
	}
	
}

class Car {
	public int price;

	public Car(int price) {
		this.price = price;
	}
}