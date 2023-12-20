using System.Security.Cryptography.X509Certificates;

internal class Program
{
	private static void Main(string[] args)
	{
		//Parent parent1 = new Child(); //can
		//Child child1 = new Parent(); //cant
		Parent parent = new();
		Child child = new();
		child.callProtected();
		parent.VirtualOverride();
		child.VirtualOverride();
	}
class Parent
	{
		int x = 1;
		int y = 2;
		
		protected void Protected()
		{
			System.Console.WriteLine(x);
		}
		private void _Private()
		{
			System.Console.WriteLine(y);
		}
		
		public virtual void VirtualOverride()
		
		{
			System.Console.WriteLine("this is virtual ready to be override");
		}
	}
class Child : Parent
	{
		public void callProtected()
		{
			Protected();
		}
		public void callPrivate()
		{
		//	Private();     ---will return error because Parent.Private() is private
		}
		
		public override void VirtualOverride()
		{
			System.Console.WriteLine("this method has been override");
		}
	}
}