//#define DEBUG -> this is by default define from .net
#define RELEASE //will still return debug version, must be defined in console using `dotnet run -c release`

internal class Program
{
    private static void Main(string[] args)
    {
        #if DEBUG
        Console.WriteLine("Debug version is compiled");

        #elif BETA
        Console.WriteLine("Beta version is compiled");

        #elif RELEASE
        Console.WriteLine("Released version is compiled");
        #endif
    }
}
