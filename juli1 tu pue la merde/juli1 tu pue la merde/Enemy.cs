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
    }
}
