using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juli1_tu_pue_la_merde
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Undefined", 3, 0, 1);
            IntroDialogues introDialogues = new IntroDialogues();

            introDialogues.Intro(player);
        }
    }
}
