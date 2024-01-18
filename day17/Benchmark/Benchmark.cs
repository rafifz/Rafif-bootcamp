using System.Text;
using BenchmarkDotNet.Attributes;


[MemoryDiagnoser]
public class StringBenchmark
{
    [Params(1, 10, 100)]
    public int N;

    [Benchmark]
    public void StringTest()
    {
        string a = string.Empty;
        for (int i = 0; i < N; i++)
        {
            a += i.ToString();
        }
    }

    [Benchmark]
    public void StringBuilderTest()
    {
        StringBuilder sb = new();
        for (int i = 0; i < N; i++)
        {
            sb.Append(i);
        }
    }
}

[MemoryDiagnoser]
public class CollectionBenchmark
{
    [Params(1, 10, 100)]
    public int N;

    [Benchmark]
    public void ListTest()
    {
        List<int> a = new();
        for (int i = 0; i < N; i++)
        {
            a.Add(i);
        }
    }
    
    [Benchmark]
    public void ArrayTest()
   {
        int[] a = new int[N];
        for (int i = 0; i < N; i++)
       {
            a[i] = i;
        //  a.Append(i);
        }
    }
}


