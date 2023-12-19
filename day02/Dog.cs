using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Animal;
namespace Dogs;
class Dog : Animals
{
	public Dog (string name, int age) : base(name, age) {}
	
	public void Bite()
	{
		System.Console.WriteLine("Dog is biting");
	}
}