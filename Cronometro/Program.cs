using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cronometro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("        C R O N O M E T R O");
            Console.WriteLine("=====================================");
            Console.WriteLine(" ");
            Console.WriteLine("Segundos = exemplo 10s = 10 segundos ");
            Console.WriteLine("Minutos  = exemplo 10m = 10 minutos  ");
            Console.WriteLine(" ");
            Console.WriteLine("Defina um tempo!");

            string data = Console.ReadLine().ToLower();
            char tipo = char.Parse(data.Substring(data.Length - 1 , 1));
            int tempo = int.Parse(data.Substring(0 , data.Length -1 ));
            int multiplicador = 1;

            if (tipo == 'm')
                multiplicador = 60;
            if (tempo == 0)
                System.Environment.Exit(0);
            PreStart(tempo * multiplicador);
            Menu();
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Lets...");
            Thread.Sleep(1000);
            Console.WriteLine("Gooo...");
            Thread.Sleep(2500);
            Start(time);
        }
        static void Start(int tempoFinal)
        {
            int tempoAtual = 0;
            while (tempoAtual != tempoFinal)
            {
                Console.Clear();
                tempoAtual++;
                Console.WriteLine(tempoAtual);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Finalizado.");
            Thread.Sleep(2500);
        }
    }
}
