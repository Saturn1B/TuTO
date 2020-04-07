﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juli1_tu_pue_la_merde
{
    class IntroDialogues
    {
        public void Intro(Player player)
        {
            Console.WriteLine("*BRUITS ASSOURDISSANTS*");
            Console.ReadLine();
            Console.WriteLine("Après un éboulement..");
            Console.ReadLine();
            Console.WriteLine("Vous vous réveillez soudainement dans ce qui semble être, une grotte..");
            Console.ReadLine();
            Console.WriteLine("*SE RÉVEILLE*");
            Console.ReadLine();
            Console.WriteLine("??? : Où suis-je ?");
            Console.ReadLine();
            SelectName(player);
        }


        public void SelectName(Player player)
        {
            string playerName;
            Console.WriteLine("Qui suis-je ?");
            Console.ReadLine();
            Console.WriteLine("Choississez votre nom : ");
            playerName = Console.ReadLine();
            Console.WriteLine("C'est bon, je me souviens, je suis " + playerName + ".");
            player.Name = playerName;
            Console.ReadLine();
            WeaponSelection(player);
        }

        public void WeaponSelection(Player player)
        {
            int choix;
            Console.WriteLine("Vous trouvez deux armes à vos pieds: une epée courte et une pioche.");
            Console.ReadLine();
            Console.WriteLine("Vous ne pouvez choisir qu'une seule arme.");
            Console.ReadLine();
            Console.WriteLine("<pioche>(1) ou <épée>(2)");
            choix = Convert.ToInt32(Console.ReadLine());
            if(choix == 1)
            {
                player.weaponInHand = new Weapon("Pioche", 3);
                Console.WriteLine(player.weaponInHand.weaponName + " est maintenant votre arme principale.");
            }
            else if(choix == 2)
            {
                player.weaponInHand = new Weapon("Epée", 3);
                Console.WriteLine(player.weaponInHand.weaponName + " est maintenant votre arme principale.");
            }
            else
            {
                Console.WriteLine("Tu n'a pas réussis a attraper ton arme ...");
                WeaponSelection(player);
            }
            Console.ReadLine();
            Text3(player);
        }

        public void Text3(Player player)
        {
            int choix;
            Console.WriteLine("Sur votre route, vous croisez un vieux mineur blessé par l'effondrement !");
            Console.ReadLine();
            Console.WriteLine("Que décidez-vous de faire ?");
            Console.ReadLine();
            Console.WriteLine("<Aider le mineur>(1) ou <Continuer>(2)");
            choix = Convert.ToInt32(Console.ReadLine());
            if (choix == 1)
            {
                Text4(player);
            }
            else if(choix == 2)
            {
                Text41(player);
            }
            else
            {
                Console.WriteLine("Vous n'avez peut être pas compris, je vous réexpose la situation");
                Console.ReadLine();
                Text3(player);
            }
        }

        public void Text4(Player player) //Si le joueur aide le mineur : cette quête se lance
        {
            int choix;
            Console.WriteLine("*HURLEMENT EFFRAYANT*");
            Console.ReadLine();
            Console.WriteLine("Un énorme monstre se présente devant vous !");
            Console.ReadLine();
            Console.WriteLine("Que decidez-vous de faire ?");
            Console.ReadLine();
            Console.WriteLine("<Essayer de tuer le monstre>(1), <Fuir>(2), <Agiter les bras comme un sauvage>(3)");
            choix = Convert.ToInt32(Console.ReadLine());
            if (choix == 1)
            {
                Enemy troll = new Enemy("Troll", 4, 2, 1);
                player.Attack(troll);
                Console.WriteLine("Mais en faisant des galipettes, vous vous êtes retouné un ongle..");
                Console.ReadLine();
                Console.WriteLine("Ça mérite quand même un coeur en moins...");
                player.LooseLife(1);
                Console.ReadLine();
                Text5(player);
            }
            else if (choix == 3)
            {
                player.LooseLife(3);
                Console.WriteLine("C'était pas bien malin ça, fallait s'y attendre");
            }
            else if(choix == 2)
            {
                Console.WriteLine("Vous prenez la fuite.");
                Console.ReadLine();
                Console.WriteLine("*ÉBOULEMENT*");
                Console.ReadLine();
                Console.WriteLine("Dans sa chute, l'éboulement emporte aussi la vie du vieux mineur...");
                Console.ReadLine();
                Text5(player);
            }
            else
            {
                Console.WriteLine("Bon c'est compliqué avec toi, aller je te réexplique");
                Console.ReadLine();
                Text4(player);
            }
        }
        public void Text41(Player player) //Sinon celle-ci se lance
        {
            Console.WriteLine("Vous prenez la fuite.");
            Console.ReadLine();
            Console.WriteLine("*ÉBOULEMENT*");
            Console.ReadLine();
            Console.WriteLine("Dans sa chute, l'éboulement emporte la vie du vieux mineur...");
            Console.ReadLine();
            Text5(player);
        }

        public void Text5(Player player)
        {
            int choix;
            Console.WriteLine("*LUMIÈRE ÉBLOUISSANTE*");
            Console.ReadLine();
            Console.WriteLine("Vous apercevez une lumière, certainement la sortie !");
            Console.ReadLine();
            Console.WriteLine("Que décidez-vous de faire ?");
            Console.ReadLine();
            Console.WriteLine("<Suivre la lumière>(1) (TRÈS FAVORABLE) ou <Retourner voir le mineur>(2) (MOINS FAVORABLE)");
            choix = Convert.ToInt32(Console.ReadLine());
            if (choix == 1)
            {
                FinalIntro();
            }
            else if (choix == 2)
            {
                Console.WriteLine("Je vous avais portant dis de pas y revenir");
                Console.ReadLine();
                player.Dead();
            }
            else
            {
                Console.WriteLine("T'es un cancre toi, aller on repart pour un explication de ce qui se passe");
                Console.ReadLine();
                Text5(player);
            }
        }
        public void FinalIntro()
        {
            Console.WriteLine("Vous êtes enfin sorti de là !");
            Console.ReadLine();
            Console.WriteLine("Vous apercevez d'un coté une rivière et de l'autre, de la fumée sûrement d'un ancien feu de camp.");
            Console.ReadLine();
            Console.WriteLine("Que decidez vous de faire ?");
            Console.ReadLine();
            Console.WriteLine("<Vers la rivière> ou <Vers la fumée>");
        }
    }
}
