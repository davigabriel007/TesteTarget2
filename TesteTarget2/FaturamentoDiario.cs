using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

class Program
{
    public class Faturamento
    {
        public int dia { get; set; }
        public double valor { get; set; }
    }

    static void Main()
    {
        // Carrega dados de faturamento do arquivo JSON
        string json = File.ReadAllText("faturamento.json");
        List<Faturamento> faturamentos = JsonConvert.DeserializeObject<List<Faturamento>>(json);

        // Filtra apenas os dias com faturamento
        var diasComFaturamento = faturamentos.Where(f => f.valor > 0).ToList();

        
        double menorValor = diasComFaturamento.Min(f => f.valor);

   
        double maiorValor = diasComFaturamento.Max(f => f.valor);

    
        double mediaMensal = diasComFaturamento.Average(f => f.valor);

        // Calcula o número de dias em que o faturamento foi superior à média mensal
        int diasAcimaDaMedia = diasComFaturamento.Count(f => f.valor > mediaMensal);

       
        Console.WriteLine($"Menor valor de faturamento: {menorValor}");
        Console.WriteLine($"Maior valor de faturamento: {maiorValor}");
        Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");
    }
}
}
