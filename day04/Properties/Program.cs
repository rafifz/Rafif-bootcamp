public class Employee
{
	private string _name = "mama";
	private int _age;

	// Getter for Name
	public string Name
	{
		
		get { return _name; }
	}

	// Setter for Name
	public int Age
	{
		get { return _age; }
		set 
		{ 
			if(value < 18)
			{
				Console.WriteLine("Age cannot be less than 18.");
			}
			else
			{
				_age = value; 
			}
		}
	}
}
class Program

{
	static void Main ()
	
	{
		Employee employee = new();
		System.Console.WriteLine(employee.Name);
		System.Console.WriteLine(employee.Age);
	}
}
