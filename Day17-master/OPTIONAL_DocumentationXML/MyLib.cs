namespace DocumentationXML;

static class MyLib
{
	public static double Add(double a, double b)
	{
		return a + b;
	}

	public static double Mul(double a, double b)
	{
		return a * b;
	}

	/// <summary>
	/// Method untuk pembagian
	/// </summary>
	/// <param name="a">ini double pertama</param>
	/// <param name="b">ini double kedua</param>
	/// <returns>menghasilkan return berupa double</returns>
	public static double Div(double a, double b)
	{
		return a / b;
	}

	public static double Sub(double a, double b)
	{
		return a - b;
	}
	

	public static int info(int a, int b) {
		return 1;
	}
}
