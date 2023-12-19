namespace Animal;
public class Animals 
{
	public int age;
	public string name;
	
	public Animals(string name, int age)
	{
		this.name = name;
		this.age = age;
	}
	
	public void Eat(string food)
	{
		System.Console.WriteLine($"eating {food}");
	}
}