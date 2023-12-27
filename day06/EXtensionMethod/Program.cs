//extension method
//extend or add method to locked library/class

//1. make public static class
//2. make public static method
//3. use this in parameter
public static class Extension
{
	public static void Print(this object x) // using object type, can fit in any type of value
	{
		System.Console.WriteLine(x);
	}
	
	public static int Plus(this int x, int y) // specific only for int
	{
		return x + y;
	}
}
internal class Program
{
	private static void Main(string[] args)
	{
		string name = "Jhon";
		int number = 123;
		name.Print();
		number.Print();
		
		number.Plus(1000).Print();
		
	}
	
}


