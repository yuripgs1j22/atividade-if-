class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número de 1 a 7:");
        int dia = int.Parse(Console.ReadLine());

        switch (dia)
        {
            case 1:
                Console.WriteLine("Segunda-feira");
                break;
            case 2:
                Console.WriteLine("Terça-feira");
                break;
            case 3:
                Console.WriteLine("Quarta-feira");
                break;
            case 4:
                Console.WriteLine("Quinta-feira");
                break;
            case 5:
                Console.WriteLine("Sexta-feira");
                break;
            default: Console.WriteLine("numero invalido coloque um numero de 1 a 7");
                    break;
        }
    }
}
