using Humans;
using Horses;
using Dogs;
internal class Program
{
	private static void Main(string[] args)
	{
		System.Console.WriteLine();
		
		//taking from Horse class
		Horse horsina = new("horsina", 26, "male");
		horsina.Eat("grass");
		System.Console.WriteLine($"horsina is {horsina.gender}");
		horsina.Kick();
		System.Console.WriteLine();
		
		//taking from Dog Class
		Dog doggo = new("doggo",5);
		doggo.Eat("bone");
		System.Console.WriteLine($"{doggo.name} is {doggo.age} years old");
		doggo.Bite();
		System.Console.WriteLine();
		
		
		//taking from Human Class
		Human jhon = new ("jhon", 48);
		jhon.Punch();
		double totalDamage = jhon.SumOfDmg(45,70,25);
		System.Console.WriteLine($"{jhon.name} dealing {totalDamage} damages to the kids");
		System.Console.WriteLine();
	}
}