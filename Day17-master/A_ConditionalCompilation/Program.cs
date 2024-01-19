#define RELEASE
#define TEST

class Program {
	static void Main() {
		#if YANTO 
		Console.WriteLine("YANTO");
		#endif
		#if TEST
		Console.WriteLine("TEST.");
		#elif RELEASE 
		Console.WriteLine("GameRunner.");
		//GameRunner gameRunner = new();
		#elif (TEST || DEBUG)
		Console.WriteLine("GameTester.");
		//GameTester gameTest = new();
		//methodTest(0);
		#else
		Console.WriteLine("Not anything.");
		#endif
		Console.WriteLine("Finish");
	}
}
