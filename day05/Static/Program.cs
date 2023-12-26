internal class Program
{
	private static void Main(string[] args)
	{
		
		System.Console.WriteLine(Static.Count()); // static method doesnt need object
		System.Console.WriteLine(Static.Count());
		System.Console.WriteLine(Static.Count());
		Static test = new Static();
		test.SetName("test");
		System.Console.WriteLine(test.name); // non static method need object
		System.Console.WriteLine(test.getCount());
	}
}

class Static 

{
	static int count;
	public string name = "";
	public static int Count()
	{
		count++;
		return count;
	}
	public int getCount()
	{
		return count;
	}
	public string SetName(string name)
	{
		return this.name = name;
	}
	
}