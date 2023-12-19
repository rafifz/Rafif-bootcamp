using Humans;
using Animal;
internal class Program
{
	private static void Main(string[] args)
	{
		//Horse horsina = new ("horsina",26);
		Horse horsina = new();
		//horsina.Eat(horsina.name, horsina.age);
		horsina.Eat("grass");
		System.Console.WriteLine();
		
		Human jhon = new ("jhon",48);
		jhon.Punch(jhon.name, jhon.age);
		double totalDamage = jhon.SumOfDmg(45,70,25);
		System.Console.WriteLine($"{jhon.name} dealing {totalDamage} damages to the kids");
	}
}