using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgBlue
{
    class Monstro
    {

        public Monstro(string nome, int vida, int ataque)
        {
            Vida = vida;
            Ataque = ataque;
            Exp = Vida + Ataque;
        } 
        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Exp { get; set; }
        public int Ataque { get; set; }


    }
}
