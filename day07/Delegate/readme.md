 # YouTube Notification System in C#

This code demonstrates a simple YouTube notification system using delegates and events. It includes a `Youtuber` class that manages subscribers and sends notifications, and a `Subscriber` class that receives notifications.

## Step-by-Step Explanation

### 1. Defining the Delegate

First, we define a delegate called `MySubscriber` that represents the method signature for the notification callback. This delegate takes a single string parameter, which is the notification message.

```csharp
public delegate void MySubcriber (string message);
```

### 2. The `Youtuber` Class

The `Youtuber` class represents the YouTube channel. It has a private field called `mySubscriber` that stores a reference to the delegate.

```csharp
class Youtuber 
{
	private event MySubcriber mySubscriber;
```

### 3. Adding Subscribers

The `AddSubscriber` method allows subscribers to register for notifications. It checks if there is already a subscriber registered, and if not, it adds the new subscriber to the `mySubscriber` delegate.

```csharp
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
```

### 4. Uploading a Video

The `UPloadVideo` method simulates the process of uploading a video to YouTube. It sends a notification to all registered subscribers when the upload is complete.

```csharp
	public void UPloadVideo()
	{
		Console.WriteLine("Uploading Video...");
		Console.WriteLine("Finished.");
		SendNotification("Here is my new video");
	}
```

### 5. Sending Notifications

The `SendNotification` method invokes the `mySubscriber` delegate, which in turn calls the `GetNotification` method of each registered subscriber.

```csharp
	public void SendNotification(string message)
	{
		mySubscriber.Invoke(message);
	}
```

### 6. The `Subscriber` Class

The `Subscriber` class represents a YouTube user who subscribes to a channel. It has a single method called `GetNotification`,
