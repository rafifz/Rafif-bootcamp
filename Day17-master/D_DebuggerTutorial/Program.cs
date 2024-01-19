using System.Diagnostics;
namespace Namespace
{
	static class Program
	{
		static void Main()
		{
			Car car = new Car();
			double a = 4.0;
			double b = 2.5;
			double answer = Add(a, b);
			Console.WriteLine($"{a} + {b} = {answer}");
		}
		static double Add(double a, double b)
		{
			double result = a * b; //Logical Error
			return result;
		}
	}
	class Car 
	{
		public int price = 3000;
		public string Name = "toyota";
	}
}