using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nim
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rodada1 = false;
            string jogada;
            int bolas = 12;

            Console.WriteLine("Olá mero mortal, eu sou Nim. Venha me desafiar no meu jogo! Sou tão inteligente que nunca perdi.");
            Console.WriteLine("As regras são simples: algumas bolas apareceram na tela. Na sua rodada você pode pegar 1, 2 ou 3 bolas.");
            Console.WriteLine("E eu faço o mesmo na minha rodada, quem pegar a última bola ganha!");
            Console.WriteLine("É tão simples te entender quanto o fato de que você vai perder.");
            Console.WriteLine("\n\n");
            Console.WriteLine("Quem começa? 'humano' ou 'maquina'?");
            player: jogada = Console.ReadLine();

            if (jogada == "humano")
            {
                rodada1 = false;
                goto jogo;
            }

            if (jogada == "maquina")
            {
                rodada1 = true;
                bolas = 13;
                goto jogo;
            }

            if (jogada != "humano" || jogada != "maquina")
            {
                Console.Clear();
                Console.WriteLine("Olá mero mortal, eu sou Nim. Venha me desafiar no meu jogo! Sou tão inteligente que nunca perdi.");
                Console.WriteLine("As regras são simples: algumas bolas apareceram na tela. Na sua rodada você pode pegar 1, 2 ou 3 bolas.");
                Console.WriteLine("E eu faço o mesmo na minha rodada, quem pegar a última bola ganha!");
                Console.WriteLine("É tão simples te entender quanto o fato de que você vai perder.");
                Console.WriteLine("\n\n");
                Console.WriteLine("Não sabe nem digitar? Quem vai começar? O 'humano' ou a 'maquina'?");
                goto player;
            }

            jogo: Console.Clear();

            rodada: for (int i = 0; i < bolas; i++)
            {
                Console.Write("O ");
            }

            if (rodada1)
            {
                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("Muito bem, eu começo! Aperte qualquer tecla para me deixar jogar");
                Console.ReadKey();
                Console.Clear();
                bolas -= 1;
                rodada1 = false;
                goto rodada;
            }

            if (bolas <= 0)
            {
                goto fim;
            }

            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("Sua vez! Tire '1', '2' ou '3' bolas.");
            invalido: jogada = Console.ReadLine();

            if (jogada == "1")
            {
                Console.Clear();
                bolas -= 1;

                for (int i = 0; i < bolas; i++)
                {
                    Console.Write("O ");
                }

                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("Muito bem. Aperte qualquer tecla para me deixar jogar");
                Console.ReadKey();
                Console.Clear();
                bolas -= 3;
                goto rodada;
            }

            if (jogada == "2")
            {
                Console.Clear();
                bolas -= 2;

                for (int i = 0; i < bolas; i++)
                {
                    Console.Write("O ");
                }

                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("Muito bem. Aperte qualquer tecla para me deixar jogar");
                Console.ReadKey();
                Console.Clear();
                bolas -= 2;
                goto rodada;
            }

            if (jogada == "3")
            {
                Console.Clear();
                bolas -= 3;

                for (int i = 0; i < bolas; i++)
                {
                    Console.Write("O ");
                }

                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("Muito bem. Aperte qualquer tecla para me deixar jogar");
                Console.ReadKey();
                Console.Clear();
                bolas -= 1;
                goto rodada;
            }

            if (jogada != "1" || jogada != "2" || jogada != "3")
            {
                Console.Clear();

                for (int i = 0; i < bolas; i++)
                {
                    Console.Write("O ");
                }

                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("O que você está fazendo? Digita direito, tire '1', '2' ou '3' bolas.");
                goto invalido;
            }

            fim: Console.Clear();
            Console.WriteLine("Eu te disse que nunca perdi! Ninguém vence o grande Nim!");
            Console.ReadKey();
        }
    }
}