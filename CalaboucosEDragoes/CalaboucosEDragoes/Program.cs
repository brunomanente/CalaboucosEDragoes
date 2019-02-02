using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalaboucosEDragoes
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "", classe = "", raca = "";
            int vida = 100;

            Console.WriteLine("Informe seu nome aventureiro.");
            nome = Console.ReadLine();

            Console.WriteLine("Informe sua raça.");
            raca = Console.ReadLine();

            Console.WriteLine("Informe sua classe.");
            classe = Console.ReadLine();

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Ficha: ");
            Console.WriteLine(nome);
            Console.WriteLine(classe);
            Console.WriteLine(raca);
            Console.WriteLine("---------------------------------");

            string resposta = "";
            Console.WriteLine("Deseja entrar na porta a sua direita?");
            resposta = Console.ReadLine();

            if (resposta == "sim")
            {
                Console.WriteLine("Tem um Monstro aqui! ");
                Console.WriteLine("Ele mordeu você e " + nome + " se ferrou!!");
                vida = vida - 50;
            }

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Ficha: ");
            Console.WriteLine("nome: " + nome);
            Console.WriteLine("classe: " + classe);
            Console.WriteLine("raca: " + raca);
            Console.WriteLine("vida: " + vida);
            Console.WriteLine("---------------------------------");
            //fazer uma opção do não

            // não precisa declarar string resposta = "";
            Console.WriteLine("Deseja entrar na porta? ou seguir para a proxima porta!!! lol");
            resposta = Console.ReadLine();

            if (resposta == "sim")
            {
                Console.WriteLine("Parabens Tem um coração aqui!! ");
                vida = vida + 50;
            }

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Ficha: ");
            Console.WriteLine("nome: " + nome);
            Console.WriteLine("classe: " + classe);
            Console.WriteLine("raca: " + raca);
            Console.WriteLine("vida: " + vida);
            Console.WriteLine("---------------------------------");

            /* if (resposta == "não") ;
                     {
                         Console.WriteLine("Proxima porta! Deseja entrar a sua Direita");
                         resposta = Console.ReadLine();
                     }
             */

            Console.WriteLine("Deseja entrar na porta?");
            resposta = Console.ReadLine();

            if (resposta == "sim")
            {
                Console.WriteLine("PULLLL TEM OUTRO MONSTRO AQUI!!!!");
                Console.WriteLine("Ele mordeu você e " + nome + " se ferrou!!");
                vida = vida - 50;
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Ficha: ");
            Console.WriteLine("nome: " + nome);
            Console.WriteLine("classe: " + classe);
            Console.WriteLine("raca: " + raca);
            Console.WriteLine("vida: " + vida);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("");

            if (vida <= 0)
            {
                Console.WriteLine("VOCÊ PERDEU!");
            }
            else
            {
                Console.WriteLine("CONTINUE....");
            }

            Console.WriteLine("Deseja entrar na caverna dos Dragoes?");
            resposta = Console.ReadLine();


            if (resposta == "sim")
            {
                Console.WriteLine("!PARABENS VOCÊ GANHOU!" + nome + "FIM!!");


                Console.ReadKey();

            }
        }
    }
}