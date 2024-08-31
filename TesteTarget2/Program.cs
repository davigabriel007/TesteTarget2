using System;

class Progam
{
    static void Main(string[] args)
    {
        Console.Write("Informe um número para verificar se pertence à sequência de Fibonacci");
        int numero = int.Parse(Console.ReadLine());

        if (PertenceFibonacci(numero))
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
        }

    }

    //Função para verificar se pertence ou não à Fibonacci
    static bool PertenceFibonacci(int n)
    {
        if (n < 0)
        {
            return false;
        }


        int a = 0;
        int b = 1;

        while (a <= n)
        {
            if (a == n)
            {
                return true;
            }

            int temp = a;
            a = b;
            b = temp + b;
        }
        return false;
    }
}