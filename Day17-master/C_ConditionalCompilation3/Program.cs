﻿//Jika dirun pasti akan ke Debug
//dotnet build -c PRODUCTION

#define DEVELOPMENT
class Program {
	static void Main() {
		#region DEVELOPMENT
		#if (DEBUG)
		Console.WriteLine("Mode DEBUG diaktifkan.");
		#elif (PRODUCTION)
		Console.WriteLine("PRODUCTION mode aktif");
		#elif (DEVELOPMENT)
		Console.WriteLine("DEVELOP mode aktif");
		#elif (FEATURETEST)
		Console.WriteLine("FEATURE mode aktif");
		#else
		Console.WriteLine("No define found");
		#endif
		#endregion
		
		#region DATABASESETTINGS
		Console.WriteLine("Program berjalan...");
		Console.Read();
		#endregion
	}
}
