public delegate void MySubcriber (string message);
class Youtuber 
{
	private event MySubcriber ?mySubscriber;
	public bool AddSubscriber (MySubcriber sub)
	{
		if (mySubscriber is null)
		{
			mySubscriber += sub;
			return true;
		}
		if (mySubscriber.GetInvocationList().Contains(sub))
		{
			return false;
		}
		mySubscriber += sub;
		return true;
	}
	public void UPloadVideo()
	{
		Console.WriteLine("Uploading Video...");
		Console.WriteLine("Finished.");
		SendNotification("Here is my new video");
	}
	public void SendNotification(string message)
	{
		mySubscriber?.Invoke(message);
	}
}
class Subscriber
{
	public void GetNotification(string message)
	{
		Console.WriteLine("Subscriber get notified : " + message);
	}
}

class Program
{
	static void Main()
	{
		Subscriber sub1 = new Subscriber();
		Subscriber sub2 = new Subscriber();
		Youtuber youtuber = new();
		
		youtuber.AddSubscriber(sub1.GetNotification);
		youtuber.AddSubscriber(sub2.GetNotification);
		youtuber.UPloadVideo();
	}
}