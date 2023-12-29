//when execption happen compiler tend to investigate where the error root was, consuimng resource
public class Human
{
	private string name;
	public int NameCounter()
	{
		if (name != null) return name.Length;
		else return 0;
	}
}

internal class Program
{
	private static void Main(string[] args)
	{
		//better use condition in method to avoid exception
		Human jhon = new();
		Console.WriteLine(jhon.NameCounter());
		
		//avoid try catch to handle exception
	   string a = null;
	   try
	   {
			Console.WriteLine(a.Length);
	   }
	   catch(NullReferenceException e)
	   {
			Console.WriteLine(e.Message);
	   }
	}
}