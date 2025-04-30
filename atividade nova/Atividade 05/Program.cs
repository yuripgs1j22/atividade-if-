class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int limite = int.Parse(Console.ReadLine());
        int count = 0;
        while (count <= limite)
        {
            Console.WriteLine(count);
            count += 3;
        }
    }
}
