internal class Program {
	//anonymous delegate or lambda expression
	private static void Main(string[] args) {
		
		Func < int, int, int > myFunc = (int a, int b) => 
		{
			return a + b;
		};
			//or
		var myFunc2 = (int a, int b) =>
		{
			return a + b;
		};
		
		var MyAction = (string a) => 	
		{
			Console.WriteLine(a);
		};
	}
}