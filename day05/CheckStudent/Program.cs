class Human 
	{
		public string Name {get;}
		private Student _student;
		public Human string (string name, Student student)
		{
			Name = name;
			_student = student;
		}
		
		public void CheckCollege()
		{System.Console.WriteLine(_student.College());}
		public void CheckHighSchool()
		{System.Console.WriteLine(_student.HighSchool());}
	}
	abstract class Student 
	{
		 public abstract string College();
		 public abstract string HighSchool();
	}
	class JakartaStudent : Student
	{
		
	}
	
internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("Hello, World!");
	}
}