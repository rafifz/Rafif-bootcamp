internal class Program
{
    private static void Main(string[] args)
    {
        int a = 5;
        int b = 5;
        Multiply(a, b);
    }

    private static int Multiply(int a, int b)
    {
        return a + b; //logical error, should've been *
        // to find this error in our program we need manually debug using debugger
    }
}
