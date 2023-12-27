using System;

class Human 
{
    public string Name {get;}
    private Student _student;
    public Human(string name, Student student)
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
    private string _college;
    private string _highSchool;

    public JakartaStudent(string college, string highSchool)
    {
        _college = college;
        _highSchool = highSchool;
    }

    public override string College()
    {
        return _college;
    }

    public override string HighSchool()
    {
        return _highSchool;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        JakartaStudent jakartaStudent = new JakartaStudent("Binus", "SMA 1");
        Human human = new Human("John", jakartaStudent);

        human.CheckCollege();
        human.CheckHighSchool();
    }
}