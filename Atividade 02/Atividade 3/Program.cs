﻿class Program
{
    static void Main()
    {
        string usuario = "admin";
        if (usuario == "admin" || usuario == "supervisor")
        {
            Console.WriteLine("Acesso concedido");
        }
    }
}
