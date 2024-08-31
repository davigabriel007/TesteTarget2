using System;

class StringContraria
{
    static void Main()
    {
       
        Console.Write("Informe uma string para inverter: ");
        string input = Console.ReadLine();

       
        string invertida = InverterString(input);

       
        Console.WriteLine("String invertida: " + invertida);
    }

    // Função que inverte a string
    static string InverterString(string str)
    {
       
        string invertida = "";

        
        for (int i = str.Length - 1; i >= 0; i--)
        {
            invertida += str[i]; 
        }

        return invertida;
    }
}