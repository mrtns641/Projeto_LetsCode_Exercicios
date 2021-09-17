using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio de Fixacao Variaveis, Tipos, Condicionais e Switch
            int qtdCaixaLeite = 4;
            int qtdOvos = 0;
            bool possuiOvos = true;
            bool possuiCarteira = true;
            double precoUnitarioLeite = 3.15;
            double precoDuziaOvo = 7.00;

            bool estaSol = true;
            bool possuiEstacionamento = false;

            if (!possuiCarteira){
                Console.WriteLine("Fiado de forma alguma, vá para casa espertão");
                Environment.Exit(0);
            }

            if (!estaSol && possuiEstacionamento) {
                Console.WriteLine("Fica em casa que é melhor");
                Environment.Exit(0);
            }

            if (possuiOvos && precoDuziaOvo < 6) {
                qtdOvos = 6;
            }

            double precoTotalLeite = qtdCaixaLeite * precoUnitarioLeite;
            double precoTotalOvos = (precoDuziaOvo / 12) *qtdOvos;
            double totalCompra = precoTotalLeite + precoTotalOvos; 

            Console.WriteLine($"Quantidade de caixas de leite compradas: {qtdCaixaLeite}");
            Console.WriteLine($"Quantidade de ovos comprados: {qtdOvos}");
            Console.WriteLine($"Total Ovos: {precoTotalOvos}");
            Console.WriteLine($"Total Leite: {precoTotalLeite}");
            Console.WriteLine($"Total de compras: {totalCompra}");   
        }
    }
}
