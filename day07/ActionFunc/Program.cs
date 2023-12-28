using System;

class Youtuber {
    public Action < object, MyEventArgs > ? mySubscriber;
    public string Name {
        get;
    }
    public Youtuber(string name) {
        Name = name;
    }
    public void UPloadVideo() {
        Console.WriteLine("Uploading Video...");
        Console.WriteLine("Finished.");
        SendNotification();
    }
    public void SendNotification() {
        mySubscriber ? .Invoke(this, new MyEventArgs());
    }
    public override string ToString() {
        return "youtuber : " + Name;
    }
}
class Publisher {
    public Action < object, MyEventArgs > ? mySubscriber;
    public string Name {
        get;
    }
    public Publisher(string name) {
        Name = name;
    }
    public void SendNotification() {
        mySubscriber ? .Invoke(this, new MyEventArgs());
    }
    public override string ToString() {
        return "publisher : " + Name;
    }

}
class MyEventArgs {
    public string data = null!;
}

class Subscriber {
    public void GetNotification(object sender, MyEventArgs e) {
        Console.WriteLine("Subscriber get notified by " + sender);
    }
}

class Program {
    static void Main() {
        Subscriber sub1 = new Subscriber();
        Subscriber sub2 = new Subscriber();

        Youtuber achmed = new Youtuber("achmed");
        achmed.mySubscriber += sub1.GetNotification;
        achmed.UPloadVideo();

        Publisher hoho = new Publisher("hoho");
        hoho.mySubscriber += sub1.GetNotification;
        hoho.SendNotification();
    }
}