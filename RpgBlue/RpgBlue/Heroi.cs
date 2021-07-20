using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgBlue
{
    class Heroi
    {
        public Heroi(string nome)
        {
            Random random = new Random();
            Nome = nome;
            Experiencia = 0;
            Nivel = 1;
            Vida = 10;
            AtaqueBase = random.Next(1, 11);
            Ataque = AtaqueBase;
        }


        int _experiencia;
        public string Nome { get; set; }
        public int Experiencia { get => _experiencia; set  {

                if ((value / 10) + 1 > Nivel)
                {
                    Console.WriteLine("Você Subiu de Nivel");
                    _experiencia = value;
                    Nivel = (_experiencia / 10) + 1;
                    Vida = Nivel * 10;
                    Ataque = AtaqueBase * Nivel;

                }
                else
                {
                    _experiencia = value;
                }
            }
        }
        public int Nivel { get; set; }
        public int Vida { get; set; }
        public int AtaqueBase { get; set; }
        public int Ataque{ get; set; }


    }
}
