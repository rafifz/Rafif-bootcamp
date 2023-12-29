public class Temperature
{
	public double Celsius { get; set; }

	public Temperature(double celsius)
	{
		Celsius = celsius;
	}

	public static Temperature operator +(Temperature a, Temperature b)
	{
		return new Temperature(a.Celsius + b.Celsius);
	}

	public override string ToString()
	{
		return $"{Celsius} °C";
	}
}
class Program
{
	static void Main(string[] args)
	{
		Temperature a = new Temperature(10);
		Temperature b = new Temperature(20);

		Temperature c = a + b; // equivalent to: Temperature c = Temperature.operator+(a, b);

		Console.WriteLine($"a = {a}");
		Console.WriteLine($"b = {b}");
		Console.WriteLine($"c = a + b = {c}");
	}
}