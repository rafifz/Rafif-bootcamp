using System.Collections;

internal class Program
{
	private static void Main(string[] args)
	{
		//--------------HashSet<T>-------------------
		HashSet<int> hashOne = new HashSet<int>();
		hashOne.Add(1);
		hashOne.Add(2);
		hashOne.Add(3);
		
		HashSet<int> hashTwo = new HashSet<int>();
		hashTwo.Add(2);
		hashTwo.Add(3);
		hashTwo.Add(4);
		
		hashOne.UnionWith(hashTwo);
		hashOne.IntersectWith(hashTwo);
		hashOne.ExceptWith(hashTwo);
		
		//--------------Queue<T>------------------- FirstInFirstOut
		Queue<int> queue = new ();
		queue.Enqueue(3);
		queue.Enqueue(4);
		queue.Enqueue(5);
		int result = queue.Dequeue(); //output : 3
		queue.Peek();                 //output : 4
		queue.Dequeue();              //output : 4
		
		//--------------Stack<T>------------------- LastInFirstOut
		Stack<int> stack = new();
		stack.Push(3);
		stack.Push(4);
		stack.Push(5);
		int resultStack = stack.Pop(); //output : 5
		stack.Peek();                  //output : 4
		stack.Pop();                   //output : 4
		stack.Peek();                  //output : 3
		int test = stack.Pop();        //output : 3

		//--------------Dicitionary<TKey,TValue>-------------------
		Dictionary<int, string> myDictionary = new();
		myDictionary.Add(1, "satu");
		myDictionary.Add(2, "dua");
		myDictionary.ContainsKey(1); // will return true
		myDictionary.ContainsValue("satU"); // false
		myDictionary.ContainsValue("satU".ToLower()); //true
		
		System.Console.WriteLine(myDictionary[1]); // call with value
		
		foreach (var kvp in myDictionary) //KeyValuePair
		{
			Console.WriteLine(kvp.Key);  // return key
			Console.WriteLine(kvp.Value); //return value
		}
		
		foreach (var key in myDictionary.Keys)
		{
			Console.WriteLine(key); //return key
		}
		
		foreach (var value in myDictionary.Values)
		{
			Console.WriteLine(value); //return value
		}
		
	}
}