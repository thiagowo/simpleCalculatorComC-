﻿namespace Calculator;
class Program
{
    static void Soma()
    {
         Console.Clear();

        Console.WriteLine("Digite o primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o segundo valor:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 + v2;

        Console.WriteLine($"O resultado da SOMA é {resultado}");
        Console.ReadKey();
        Menu();
    }
    static void Subtracao()
    {
        Console.Clear();

        Console.WriteLine("Digite o primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 - v2;
        Console.WriteLine($"O resultado da SUBTRAÇÃO é {resultado}");
        Console.ReadKey();
        Menu();
    }
    static void Divisao()
    {
        Console.Clear();

        Console.WriteLine("Digite o primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 / v2;
        Console.WriteLine($"O resultado da DIVISÃO é {resultado}");
        Console.ReadKey();
        Menu();
    }
    static void Multiplicacao()
    {
        Console.Clear();
        
        Console.WriteLine("Digite o primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 * v2;
        Console.WriteLine($"O resultado da MULTIPLICAÇÃO é {resultado}");
        Console.ReadKey();
        Menu();
    }
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Olá! Digite a opção desejada:");
        Console.WriteLine("[1] - Soma");
        Console.WriteLine("[2] - Subtração");
        Console.WriteLine("[3] - Divisão");
        Console.WriteLine("[4] - Multiplicação");
        Console.WriteLine("[5] - Sair");
        Console.WriteLine("-----------------------------"); 
        short opcao = short.Parse(Console.ReadLine());

        switch(opcao) 
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 5: System.Environment.Exit(0); break;
            default: Menu(); break;
        }  
    }
    
    static void Main(string[] args)
    {
       Menu();
    }
}
