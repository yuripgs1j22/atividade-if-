﻿class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Escolha a operação (digite 'adição', 'subtração', 'multiplicação' ou 'divisão'):");
        string operacao = Console.ReadLine().ToLower();

        double resultado;

        switch (operacao)
        {
            case "adição":
                resultado = num1 + num2;
                Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
                break;
            case "subtração":
                resultado = num1 - num2;
                Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
                break;
            case "multiplicação":
                resultado = num1 * num2;
                Console.WriteLine($"Resultado: {num1} * {num2} = {resultado}");
                break;
            case "divisão":
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    Console.WriteLine($"Resultado: {num1} / {num2} = {resultado}");
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                }
                break;
            default:
                Console.WriteLine("Operação inválida. Por favor, escolha 'adição', 'subtração', 'multiplicação' ou 'divisão'.");
                break;
        }
    }
}
