internal class Program
{
	class MyCollection <T> //using generic
	{
		public T[] myCollection; // this T[] is changeable when we call it later, like string[], int[]
		public int count;
		public MyCollection(int size)
		{
			myCollection = new T[size];
			count = -1;
		}
		public bool AddCollection(T add)
		{
			if (count == myCollection.Length -1) return false;
			count ++;
			myCollection[count] = add;
			return true;
		}
		public T GetCollection(int index)
		{
			if (index > myCollection.Length - 1) return default;
			return myCollection[index];
		}
	}
	private static void Main(string[] args)
	{
		MyCollection <int> myIntCollection = new (3); // changing <T> to int
		myIntCollection.AddCollection(1);
		myIntCollection.AddCollection(2);
		myIntCollection.AddCollection(3);
		myIntCollection.AddCollection(4);
		
		System.Console.WriteLine(myIntCollection.GetCollection(5));
		
		
	}
}