internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        int d =int.Parse(Console.ReadLine());
        Console.WriteLine(count(d));
        Console.ReadKey();
    }
    static int count(int n)
    {
        if (n < 10)
            return 1;
        else
            return 1 + count(n / 10);
    }
}