# Event-Based Notification System in C#

This code demonstrates an event-based notification system in C# using delegates and events. It involves three classes: `Youtuber`, `Publisher`, and `Subscriber`, each with its own responsibilities and interactions.

## Understanding the Code

### 1. Delegate Declaration:

```csharp
public delegate void EventHandler(object sender, EventArgs e);
```

- A delegate is a type-safe reference to a method. In this case, the `EventHandler` delegate is defined to handle events with an `object` sender and an `EventArgs` argument.

### 2. Custom Event Arguments:

```csharp
public class NotificationEventArgs : EventArgs
{
    public string Name { get; set; }
    public string Message { get; set; }

    public NotificationEventArgs(string name, string message)
    {
        Name = name;
        Message = message;
    }
}
```

- `NotificationEventArgs` is a custom event argument class derived from `EventArgs`. It contains two properties: `Name` and `Message`, which will be used to pass additional information about the event.

### 3. `Youtuber` Class:

```csharp
public class Youtuber
{
    public string Name { get; set; }
    public event EventHandler<NotificationEventArgs> Notification;

    public void UploadVideo()
    {
        Console.WriteLine($"{Name} is Uploading ...");
        Console.WriteLine($"{Name} is Finished Uploading");
        Notification?.Invoke(this, new NotificationEventArgs(Name, "New Video Is Out"));
    }
}
```

- The `Youtuber` class represents a YouTuber who can upload videos and notify subscribers when a new video is available.
- It has a `Name` property and an event called `Notification` of type `EventHandler<NotificationEventArgs>`.
- The `UploadVideo` method simulates the process of uploading a video. It prints messages to the console and then raises the `Notification` event with appropriate arguments.

### 4. `Publisher` Class:

```csharp
public class Publisher
{
    public string Name { get; set; }
    public event EventHandler<NotificationEventArgs> Notification;

    public void SendNotification(string message)
    {
        Notification?.Invoke(this, new NotificationEventArgs(Name, message));
    }
}
```
