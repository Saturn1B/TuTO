using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juli1_tu_pue_la_merde
{
    class Enemy
    {
        public string Name;
        public int life;
        public int xpToGive;
        public int strengh;

        public Enemy(string Name, int life, int xpToGive, int strengh)
        {
            this.Name = Name;
            this.life = life;
            this.xpToGive = xpToGive;
            this.strengh = strengh;
        }

        public void Attack(Player player)
        {
            player.life -= strengh;
            Console.WriteLine(player.Name + " a perdu " + strengh + " vie.");
            Console.ReadLine();
            Console.WriteLine(player.Name + " a " + player.life + " de vie.");
            Console.ReadLine();
            if (player.life <= 0)
            {
                Console.WriteLine(player.Name + " n'a plus de vie. ");
                Console.ReadLine();
                Console.WriteLine("Vous êtes mort.");
                Console.ReadLine();
            }
            else if (player.life > 0)
            {
                Console.WriteLine("A vous d'attaquer.");
                Console.ReadLine();
                player.Attack(this);
            }
        }
    }
}
