using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_07
{
    internal class Guerreiro : Ações
    {
        Random random = new Random();
        
        public override void Andar()
        {
           espaço_percorrido = random.Next(1,2);
           Console.WriteLine($"O Guerreiro andou {espaço_percorrido} espaços");
        }

        public override void Atacar()
        {
            int resultado = 0;

            for (int i = 0; i < 2; i++)
            {
                ataque = random.Next(1,6);
                resultado += ataque;
            } 
            Console.WriteLine($"O Guerreiro atacou {resultado} com a espada");
        }

        public override void Defender()
        {
            ataque = random.Next(1, 6);
            Console.WriteLine($"O Guerreiro defendeu {ataque} com o escudo");

        }
    }
}
