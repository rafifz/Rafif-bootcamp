internal class Program
{
	
	abstract class Animal 
	{
		protected int age;
		protected string name;
		public Animal (int age, string name)
		{
			this.age = age;
			this.name = name;
		}
		public abstract void MakeSound(); // abstract mean the child MUST implement the method, unlike virtual override
		public virtual void Attack()
		{
			System.Console.WriteLine("animal is attacking");
		}
		
	}

	class Dog : Animal
	{
		public Dog (int age,string name) :base(age,name){}
		public override void MakeSound()
		{
			System.Console.WriteLine($"{name} is Barking");
		}
	}

	private static void Main(string[] args)
	{
		Animal spike = new Dog(25,"spike");
		// System.Console.WriteLine(spike.age); error due to Animal.age is protected access 
		spike.MakeSound();
		spike.Attack();
	}
}