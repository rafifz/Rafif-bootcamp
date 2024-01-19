#define ANDROID
class Program {
	static void Main() {
		
		#if ANDROID
		#region ANDROID
		Console.WriteLine("ANDROID");
		#endregion
		#elif APPLE
		#region APPLE
		Console.WriteLine("APPLE");
		#endregion
		#endif
		#warning 'eadsasd'
		Console.WriteLine("Program berjalan...");
	}
} 