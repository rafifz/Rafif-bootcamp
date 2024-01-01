using System;

public delegate void EventHandler(object sender, EventArgs e);

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

class Youtuber
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

class Publisher
{
    public string Name { get; set; }
    public event EventHandler<NotificationEventArgs> Notification;

    public void SendNotification(string message)
    {
        Notification?.Invoke(this, new NotificationEventArgs(Name, message));
    }
}
class Subscriber
{
    public string Name { get; set; }

    public void GetNotification(object sender, NotificationEventArgs e)
    {
        Console.WriteLine($"{Name} get notification from {e.Name} : {e.Message}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Youtuber jhon = new Youtuber {Name="Jhon"};
        Publisher doe = new Publisher {Name="Doe"};
        Subscriber bocil = new() {Name = "Bocil"};
        jhon.Notification += bocil.GetNotification;
        doe.Notification += bocil.GetNotification;
        jhon.UploadVideo();
        doe.SendNotification("JJK vol.5 is out");
    }
}
