using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_07
{
    internal class Mago : Ações
    {
        Random random = new Random();
        int elemento = 0;

        public override void Andar()
        {
            espaço_percorrido = random.Next(1, 3);
            Console.WriteLine($"O Mago correu {espaço_percorrido} espaços");
        }

        public override void Atacar()
        {   
            ataque = random.Next(1, 6);
            string tipo;
            
            error:
            Console.WriteLine("Escolha um elemento para atacar: \n 1.Fogo \n 2.Terra \n 3.Ar \n 4.Água");
            int elemento = int.Parse(Console.ReadLine());

            switch (elemento)
            {
                case 1:
                    tipo = "fogo";
                    Console.WriteLine($"O mago atacou {ataque} vezes usando {tipo}");
                    break;

                case 2:
                    tipo = "terra";
                    Console.WriteLine($"O mago atacou {ataque} vezes usando {tipo}");
                    break;

                case 3:
                    tipo = "ar";
                    Console.WriteLine($"O mago atacou {ataque} vezes usando {tipo}");
                    break;

                case 4:
                    tipo = "água";
                    Console.WriteLine($"O mago atacou {ataque} vezes usando {tipo}");
                    break;

                default:
                    Console.WriteLine("Elemento inválido"); 
                    goto error;
                    break;
            }
        }

        public override void Defender()
        {
            defesa = random.Next(1, 6);
            Console.WriteLine($"O mago se defendeu {defesa}x com barreiro de ar");

        }
    }
}
