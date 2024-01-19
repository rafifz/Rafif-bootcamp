using System.Diagnostics;

static class Program
{
	static void Main()
	{
		int userIDfromUser = 123123;
		string passFromUser = "pass";
		Debug.WriteLine(DateTime.Now + " [DEBUG] " + userIDfromUser + "	 " + passFromUser);

		int RegisteredUserId = 123123;
		string RegisteredPass = "pass123";
		Trace.WriteLine(DateTime.Now + " [TRACE] Userid and password inserted");
		
		Debug.WriteLine(DateTime.Now + " [DEBUG]");
		//Debug.Assert(passFromUser == RegisteredPass , "Password Salah!");
		Trace.Assert(false, "TraceAssert says, I am watching!");
		
		Console.WriteLine("Finish");
	}
}