using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Animal;
namespace Horses;
class Horse : Animals
{
	public string gender;
	public Horse (string name, int age, string gender)
	{
	 this.gender = gender;	
	}
	
	public void Kick()
	{
		System.Console.WriteLine("horse is kicking");
	}
}