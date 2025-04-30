class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int num = int.Parse(Console.ReadLine());
        int result = 0;
        int count = 0;
        while (count < 10)
        {
            result += num;
            count++;
        }
        Console.WriteLine("Resultado: " + result);
    }
}
