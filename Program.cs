using System;
using System.Collections.Generic;

//atvdd1
class Program
{
    static void Main()
    {
        //atvdd1
        double a = 10.5;
        double b = 2.5;

        Console.WriteLine($"Adição: {a} + {b} = {a + b}");
        Console.WriteLine($"Subtração: {a} - {b} = {a - b}");
        Console.WriteLine($"Multiplicação: {a} * {b} = {a * b}");
        Console.WriteLine($"Divisão: {a} / {b} = {a / b}");
    

        //atvdd2
        List<string> bandas = new List<string>();
        

        bandas.Add("The Beatles");
        bandas.Add("Led Zeppelin");
        bandas.Add("Pink Floyd");

        Console.WriteLine("Bandas adicionadas:");

        //atvdd3
        for (int i = 0; i < bandas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {bandas[i]}");
        }
    }
}

