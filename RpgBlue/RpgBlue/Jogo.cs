using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgBlue
{
    class Jogo
    {
        Heroi heroi;

        public void iniciar()
        {
            Console.WriteLine("Informe o Nome do Jogador:");
            heroi = new Heroi(Console.ReadLine());
            Menu();
        }

        void Menu()
        {
            Console.Clear();
            ApresentarHeroi();
            Console.WriteLine("Escolha Contra quem Deseja Lutar");
            Console.WriteLine("1 - Orc");
            Console.WriteLine("2 - Troll");
            Console.WriteLine("3 - Goblin");
            Console.WriteLine("0 - Sair");

            switch (Console.ReadLine())
            {
                case "1":
                    Batalhar(new Monstro("Orc", heroi.Nivel * 2, heroi.Nivel));
                    break;
                case "2":
                    Batalhar(new Monstro("Troll", heroi.Nivel * 5, heroi.Nivel * 2));
                    break;
                case "3":
                    Batalhar(new Monstro("Goblin", heroi.Nivel * 6, heroi.Nivel * 4));
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Opção Inválida...");
                    break;
            }

            if(heroi.Vida < 1)
            {
                Console.WriteLine("Você Morreu");
                Console.WriteLine("*** GAME OVER ***");
                return;
            }

            Console.WriteLine("Digite uma Tecla Para Continuar..");
            Console.ReadKey();
            Menu();
        }

        void Batalhar(Monstro monstro)
        {
            Console.Clear();
            ApresentarHeroi();
            Console.WriteLine($"Seu Oponente é o Montro {monstro.Nome}");
            Console.WriteLine($"Vida: {monstro.Vida}");
            Console.WriteLine($"Experiência: {monstro.Exp}");
            Console.WriteLine($"Ataque: {monstro.Ataque}");
            Console.WriteLine("-----");

            Console.WriteLine("Você Deseja:");
            Console.WriteLine("1 - Lutar:");
            Console.WriteLine("2 - Fugir");
            switch (Console.ReadLine())
            {
                case "1":
                    heroi.Vida -= monstro.Ataque;
                    monstro.Vida -= heroi.Ataque;
                    Console.WriteLine($"Você Perdeu  {monstro.Ataque} de Vida");
                    Console.WriteLine($"Você Causou {heroi.Ataque} de Dano ao {monstro.Nome} .. ");

                    if (heroi.Vida < 1) return;
                    else if (monstro.Vida < 1)
                    {
                        Console.WriteLine($"Você Derrotou {monstro.Nome} e Ganhou {monstro.Exp} de Exp");
                        heroi.Experiencia += monstro.Exp;
                        return;
                    }
                    break;
                case "2":
                    Console.WriteLine("Opção Fugir Ativada");
                    return;
                default:
                    Console.WriteLine("Opção Inválida...");
                    break;
            }
            Console.WriteLine("Digite uma Tecla Para Continuar..");
            Console.ReadKey();
            Batalhar(monstro);
        }

        void ApresentarHeroi()
        {
            Console.WriteLine($"Nome: {heroi.Nome}");
            Console.WriteLine($"Nivel: {heroi.Nivel}");
            Console.WriteLine($"Vida: {heroi.Vida}");
            Console.WriteLine($"Experiência: {heroi.Experiencia}");
            Console.WriteLine($"Ataque: {heroi.Ataque}");
            Console.WriteLine("---------");
        }
    }
}
