using System;

public interface IShoot 
{
	public void Shoot();
}
public interface IBomb
{
	public void Bomb();
}

public class CheapWeapon : IShoot
{
	public void Shoot()
	{
		System.Console.WriteLine("cheap weapon is shooting slowly");
	}
}
public class ExpensiveWeapon : IShoot, IBomb

{
	public void Bomb()
	{
		System.Console.WriteLine("expensive weapon is bombing");
	}

	public void Shoot()
	{
		System.Console.WriteLine("expensive weapon is shooting rapidly");
	}
}

class Program
{
	static void Main(string[] args)
	{
	  Shooting(new ExpensiveWeapon());
	  Shooting(new CheapWeapon());
	  Bombing (new ExpensiveWeapon());
	  // Bombing (new CheapWeapon()); will return error cus CheapWeapon doesnt have IBomb parent. 
	  
	}
	static void Shooting(IShoot shoot)
	{
		shoot.Shoot();
	}
	static void Bombing(IBomb bomb)
	
	{
		bomb.Bomb();
	}
}