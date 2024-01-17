//#define DEBUG the default define from .net 
#define BETA //will still return debug version, must be defined in console using `dotnet run -c release`

#if DEBUG
Console.WriteLine("Debug version is compiled");
#elif BETA
Console.WriteLine("Beta version is compiled");
#elif RELEASE
Console.WriteLine("Released version is compiled");
#endif 
