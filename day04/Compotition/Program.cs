using CarComponent;
//Composition
class Program 
{
	static void Main() 
	{
		Car car2 = new Car(new Engine(),new Lamp()); //instance Car with 2 class as a constructor
		car2.engine.cylinder=2;
		car2.Start();
		
		Engine newEngine = new();
		car2.ChangeEngine(newEngine);
		car2.Start();
		
		ElectricEngine elEngine = new(); //ElectricEngine overiding Engine 
		car2.ChangeEngine(elEngine);
		car2.Start();
		
		Car car3 = new Car(new Engine(),new Lamp());
		car3.engine.cylinder=3;
		car3.Start();
		
		
	}
}