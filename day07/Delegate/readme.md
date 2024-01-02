# YouTube Notification System

This code demonstrates a simple notification system for a YouTube-like platform. It involves three main classes: `Youtuber`, `Publisher`, and `Subscriber`. Let's break down the code step by step:

## 1. Defining the `Notification` Delegate:

```csharp
public delegate void Notification(string name, string message);
```

- We define a delegate called `Notification` that takes two string parameters: `name` and `message`. This delegate represents the signature of the notification method that will be used to send notifications.

## 2. `Youtuber` Class:

```csharp
class Youtuber
{
    public string Name { get; set; }
    public event Notification notification;

    public void UploadVideo()
    {
        Console.WriteLine($"{Name} is Uploading ...");
        Console.WriteLine($"{Name} is Finished Uploading");
        SendNotif("New Video Is Out");
    }

    public void SendNotif(string message)
    {
        notification(Name, message);
    }
}
```

- The `Youtuber` class represents a YouTuber who can upload videos and send notifications to subscribers.
- It has a `Name` property to store the YouTuber's name.
- It defines an event called `notification` of type `Notification` delegate. This event will be used to notify subscribers when a new video is uploaded.
- The `UploadVideo` method simulates the process of uploading a video. It prints messages to the console indicating the upload process and then calls the `SendNotif` method to send a notification.
- The `SendNotif` method takes a `message` as an argument and invokes the `notification` event, passing the YouTuber's name and the message as arguments.

## 3. `Publisher` Class:

```csharp
class Publisher
{
    public string Name { get; set; }
    public event Notification notification;

    public void SendNotif(string message)
    {
        notification(Name, message);
    }
}
```

- The `Publisher` class represents a publisher who can send notifications to subscribers.
- It has a `Name` property to store the publisher's name.
- It defines an event called `notification` of type `Notification` delegate. This event will be used to notify subscribers when a new publication is available.
