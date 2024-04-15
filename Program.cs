using System;

public class Program
{
    public static void Main()
    {



        Console.WriteLine("Entre a primeira nota: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Entre a segunda nota: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Entre a terceira nota: ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("Entre a quarta nota: ");
        int d = int.Parse(Console.ReadLine());

        int media = (a + b + c + d) / 4;

        Console.WriteLine();
        Console.WriteLine("A média do aluno foi: " + media);
        Console.WriteLine();

        if (media >= 5)
        {
            Console.WriteLine("aprovado");
        }

        else if (media == 4)
            Console.WriteLine("Em exame");

        else
        {
            Console.WriteLine("Reprovado");
        }


    }
}
