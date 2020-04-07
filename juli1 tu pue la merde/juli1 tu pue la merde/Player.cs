using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juli1_tu_pue_la_merde
{
    class Player
    {
        public string Name;
        public int life;
        public int xp;
        public int strengh;
        public Weapon weaponInHand = new Weapon("Punch", 1);

        public Player(string Name, int life, int xp, int strengh)
        {
            this.Name = Name;
            this.life = life;
            this.xp = xp;
            this.strengh = strengh;
            //this.weaponInHand = weaponInHand;
        }

        public void Attack(Enemy enemy)
        {
            enemy.life -= weaponInHand.damage * strengh;
            Console.WriteLine(enemy.Name + " a perdu " + weaponInHand.damage * strengh + " vie.");
            Console.ReadKey();
            if (enemy.life <= 0)
            {
                Console.WriteLine(enemy.Name + " est mort. ");
                Console.ReadKey();
                Console.WriteLine(Name + " gagne " + enemy.xpToGive + " xp.");
                Console.ReadKey();
                xp += enemy.xpToGive;
                Console.WriteLine(Name + " a " + xp + " xp.");
                Console.ReadKey();
                Console.WriteLine("Bravo vous avez tué " + enemy.Name + "!");
                Console.ReadKey();
            }
            else if(enemy.life > 0)
            {
                Console.WriteLine(enemy.Name + " a " + enemy.life + " de vie.");
                Console.ReadKey();
                Console.WriteLine(enemy.Name + " attaqua a son tour.");
                Console.ReadKey();
                enemy.Attack(this);
            }
        }

        public void LooseLife(int damage)
        {
            Console.WriteLine("Vous perdez " + damage + " de vie.");
            life -= damage;
            if(life <= 0)
            {
                Dead();
            }
        }

        public void Dead()
        {
            Console.WriteLine("Vous êtes mort.");
            Console.ReadKey();
            Console.WriteLine("Relancer le jeu.");
            System.Environment.Exit(0);
        }
    }
}
