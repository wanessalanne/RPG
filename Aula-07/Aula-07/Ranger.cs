using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_07
{
    internal class Ranger : Ações
    {
        Random random = new Random();
        public override void Andar()
        {
            espaço_percorrido = random.Next(1, 5);
            Console.WriteLine($"O Ranger pulou {espaço_percorrido} espaços");
        }

        public override void Atacar()
        {
            ataque = random.Next(1, 6);
            Console.WriteLine($"O Ranger atacou {ataque}X com o arco e flecha");
        }

        public override void Defender()
        {
            defesa = random.Next(1, 6);
            Console.WriteLine($"O Ranger se esquivou {defesa}X");
        }
    }
}
