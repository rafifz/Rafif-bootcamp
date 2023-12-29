using System.Collections;

class GameControler
{
	
}
public interface IPlayer
{
	
}

internal class Program
{
	private static void Main(string[] args)
	{
		int[] myInt = {1,2,3};
		IEnumerator enumerator = myInt.GetEnumerator();
												//myInt[-1]
		Console.WriteLine(enumerator.MoveNext());
		Console.WriteLine(enumerator.Current); // get myInt[0]
		
		Console.WriteLine(enumerator.MoveNext());
		Console.WriteLine(enumerator.Current); // get myInt[1]
		
		Console.WriteLine(enumerator.MoveNext());
		Console.WriteLine(enumerator.Current); // get myInt[2]
		
		Console.WriteLine(enumerator.MoveNext()); // return false because myInt[3] doesnt exist
		
		enumerator.Reset();                    // reset to myInt[-1]
		Console.WriteLine(enumerator.MoveNext());
		Console.WriteLine(enumerator.Current);

	}
}