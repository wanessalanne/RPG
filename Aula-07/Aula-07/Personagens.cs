using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_07
{
    abstract class Ações
    {
        protected int espaço_percorrido;
        protected int ataque;
        protected int defesa;
        abstract public void Atacar();
        abstract public void Andar();
        abstract public void Defender();
    }
}
