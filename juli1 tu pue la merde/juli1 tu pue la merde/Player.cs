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
            Console.WriteLine(enemy.Name + " a perdu " + weaponInHand.damage * strengh + " vie");
            Console.ReadLine();
            Console.WriteLine(enemy.Name + " a " + enemy.life + " de vie");
            Console.ReadLine();
            if (enemy.life <= 0)
            {
                Console.WriteLine(enemy.Name + " est mort ");
                Console.ReadLine();
                Console.WriteLine(Name + " gagne " + enemy.xpToGive + " xp");
                Console.ReadLine();
                xp += enemy.xpToGive;
                Console.WriteLine(Name + " a " + xp + " xp");
                Console.ReadLine();
            }
            else if(enemy.life > 0)
            {

            }
        }

        public void LooseLife(int damage)
        {
            Console.WriteLine("Vous perdez " + damage + " de vie");
            life -= damage;
            if(life <= 0)
            {
                Dead();
            }
        }

        public void Dead()
        {
            Console.WriteLine("Vous êtes mort");

        }
    }
}
