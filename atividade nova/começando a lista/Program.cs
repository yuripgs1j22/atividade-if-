class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int N = int.Parse(Console.ReadLine());
        int count = 1;
        while (count <= N)
        {
            Console.WriteLine(count);
            count++;
        }
    }
}
