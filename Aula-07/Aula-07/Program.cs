using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_07
{
    internal class RPG    {
        static void Main(string[] args)
        {
            Guerreiro guerreiro = new Guerreiro();
            Mago mago = new Mago();
            Ranger ranger = new Ranger();

            string personagem = "";
            Console.WriteLine("============================");
            Console.WriteLine("===== CAMPO DE BATALHA ======");
            Console.WriteLine("============================");

            Console.WriteLine("\n Escolha um personagem: \n \n 1.Guerreiro \n 2.Mago \n 3.Ranger");
            int escolha = int.Parse(Console.ReadLine());

            switch(escolha)
            {
                case 1: 
                    personagem = "Guerreiro";
                    Console.WriteLine($"\n Personagem escolhido: \n {personagem}");
                    break;
                case 2:
                    personagem = "Mago";
                    Console.WriteLine($"\n Personagem escolhido:\n {personagem}");
                    break;
                case 3:
                    personagem = "Ranger";
                    Console.WriteLine($"\n Personagem escolhido: \n {personagem}");
                    break;
            }
            Console.WriteLine("\n Escolha uma ação: " +
                "\n1.Andar " +
                "\n2.Atacar " +
                "\n3.Defender");
            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    if (personagem == "Guerreiro")
                    {
                        guerreiro.Andar();
                    }
                    else if (personagem == "Mago")
                    {
                        mago.Andar();
                    }
                    else
                    {
                        ranger.Andar();
                    }
                    break;
                case 2:
                    if (personagem == "Guerreiro")
                    {
                        guerreiro.Atacar();
                    }
                    else if (personagem == "Mago")
                    {
                        mago.Atacar();
                    }
                    else
                    {
                        ranger.Atacar();
                    }
                    break;
                case 3:
                    if (personagem == "Guerreiro")
                    {
                        guerreiro.Defender();
                    }
                    else if (personagem == "Mago")
                    {
                        mago.Defender();
                    }
                    else
                    {
                        ranger.Defender();
                    }
                    break;
            }
            while (escolha != 0)
            {
                Console.WriteLine("\n Escolha uma ação: " +
               "\n1.Andar " +
               "\n2.Atacar " +
               "\n3.Defender" +
               "\n0. SAIR");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        if (personagem == "Guerreiro")
                        {
                            guerreiro.Andar();
                        }
                        else if (personagem == "Mago")
                        {
                            mago.Andar();
                        }
                        else
                        {
                            ranger.Andar();
                        }
                        break;
                    case 2:
                        if (personagem == "Guerreiro")
                        {
                            guerreiro.Atacar();
                        }
                        else if (personagem == "Mago")
                        {
                            mago.Atacar();
                        }
                        else
                        {
                            ranger.Atacar();
                        }
                        break;
                    case 3:
                        if (personagem == "Guerreiro")
                        {
                            guerreiro.Defender();
                        }
                        else if (personagem == "Mago")
                        {
                            mago.Defender();
                        }
                        else
                        {
                            ranger.Defender();
                        }
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
