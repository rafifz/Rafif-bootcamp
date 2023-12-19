using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Animal;
class Horse : Animals
{
	public Horse (string name, int age)
	{
		 
	}
	public void kick(string food)
	{
		System.Console.WriteLine("horse is kicking");
	}
}