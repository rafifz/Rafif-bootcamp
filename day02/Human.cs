namespace Humans;
class Human 
{
	public string name;
	public int age;
	public Human(string name,int age)
	{
		this.name = name ;
		this.age = age ;
	}
	public void Punch(string name, int age)
	{
		System.Console.WriteLine($"{name}, {age} years old, is punching kids");
	}
	public int SumOfDmg(params int[] damages) //array of param with 1 type of data
	{
		int result = 0;
		foreach (int damage in damages)
		{
			result = result + damage;
		}
		return result;
	}
	
}