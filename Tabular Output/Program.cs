class TabularOutput
{
    static void Main(string[] args)
    {
        Console.WriteLine("N\t10*N\t100*N\t1000*N");

        Console.WriteLine();

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i + "\t" + i * 10 + "\t" + i * 100 + "\t" + i * 1000);
        }
    }
}
