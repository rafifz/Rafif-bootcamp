using DocumentationXML;
static class Program
{
	static void Main() 
	{
		Console.WriteLine();
		double a = 4.5;
		double b = 2.5;
		double Add = MyLib.Div(a, b);


		double resulttt = MyLib.Div(3.0, 4.9);
		double Mul = MyLib.Mul(a, b);
		double Div = MyLib.Div(a, b);
		double Sub = MyLib.Sub(a, b);
		string answer = $"{Add} {Mul} {Div} {Sub}";
		Console.WriteLine($"{a} + {b} = {answer}");

		Calculator calc = new();
		int result = calc.Multiplication(3, 5);
		
		Console.WriteLine();
		Calculator calculator = new();
		calculator.Multiplication(3,4);
	}
	
}
/// <summary>
/// asdasdasdasd
/// </summary>
class Calculator
{
	/// <summary>
	/// Ini adalah metode untuk perkalian
	/// </summary>
	/// <param name="a">Parameter pertama berupa int untuk perkalian</param>
	/// <param name="b">Parameter kedua berupa int untuk perkalian</param>
	/// <returns>Menghasilkan nilai</returns> 
	public int Multiplication(int a, int b) 
	{
		return a * b;
	}
}