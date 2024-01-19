internal class Program
{
    private static async void Main(string[] args)
    {
        await MyMethod();
    }

    // public static Task MyMethod()
    // {
    //     return Task.Delay(2000);
    // }

    public static async Task MyMethod()
    {
        await Task.Delay(2000);
    }
}
