public delegate void Notification (string name, string message);
class Youtuber
{
    public string Name{get;set;}
    public event Notification notification;
    
    public void UploadVideo()
    {
        Console.WriteLine($"{Name} is Uploading ...");
        Console.WriteLine($"{Name} is Finished Uploading");
        SendNotif("New Video Is Out");
    }
    public void SendNotif(string message)
    {
        notification (Name, message);
    }
}
class Publisher
{
    public string Name{get;set;}
    public event Notification notification;
    
    public void SendNotif(string message)
    {
        notification (Name, message);
    }
}
class Subscriber
{
    public string Name{get;set;}
    public void GetNotif(string name, string message)
    {
        Console.WriteLine($"{Name} get notif from {name} : {message}");
    }
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Youtuber jhon = new Youtuber {Name="Jhon"};
        Publisher doe = new Publisher {Name="Doe"};
        Subscriber bocil = new() {Name = "Bocil"};
        jhon.notification += bocil.GetNotif;
        doe.notification += bocil.GetNotif;
        jhon.UploadVideo();
        doe.SendNotif("JJK vol.5 is out");
    }
}
