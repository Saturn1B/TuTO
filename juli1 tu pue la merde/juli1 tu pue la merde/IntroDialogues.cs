using System;
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
            Console.ReadKey();
            Console.WriteLine("Après un éboulement..");
            Console.ReadKey();
            Console.WriteLine("Vous vous réveillez soudainement dans ce qui semble être, une grotte..");
            Console.ReadKey();
            Console.WriteLine("*SE RÉVEILLE*");
            Console.ReadKey();
            Console.WriteLine("??? : Où suis-je ?");
            Console.ReadKey();
            SelectName(player);
        }


        public void SelectName(Player player)
        {
            string playerName;
            Console.WriteLine("Qui suis-je ?");
            Console.ReadKey();
            Console.WriteLine("Choississez votre nom : ");
            playerName = Console.ReadLine();
            if (playerName == "")
            {
                Console.WriteLine("Vous n'avez pas compris, il faut entrer votre prénom. Aller on recomence.");
                SelectName(player);
            }
            else
            {
                Console.WriteLine("C'est bon, je me souviens, je suis " + playerName + ".");
                player.Name = playerName;
                Console.ReadKey();
                WeaponSelection(player);
            }
        }

        public void WeaponSelection(Player player)
        {
            //string choix1;
            int choix;
            Console.WriteLine("Vous trouvez deux armes à vos pieds: une epée courte et une pioche.");
            Console.ReadKey();
            Console.WriteLine("Vous ne pouvez choisir qu'une seule arme.");
            Console.ReadKey();
            Console.WriteLine("<pioche>(1) ou <épée>(2)");
            while (int.TryParse(Console.ReadLine(), out choix) == false) ;
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
            Console.ReadKey();
            Text3(player);
        }

        public void Text3(Player player)
        {
            int choix;
            Console.WriteLine("Sur votre route, vous croisez un vieux mineur blessé par l'effondrement !");
            Console.ReadKey();
            Console.WriteLine("Que décidez-vous de faire ?");
            Console.ReadKey();
            Console.WriteLine("<Aider le mineur>(1) ou <Continuer>(2)");
            while (int.TryParse(Console.ReadLine(), out choix) == false) ;
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
                Console.ReadKey();
                Text3(player);
            }
        }

        public void Text4(Player player) //Si le joueur aide le mineur : cette quête se lance
        {
            int choix;
            Console.WriteLine("*HURLEMENT EFFRAYANT*");
            Console.ReadKey();
            Console.WriteLine("Un énorme monstre se présente devant vous !");
            Console.ReadKey();
            Console.WriteLine("Que decidez-vous de faire ?");
            Console.ReadKey();
            Console.WriteLine("<Essayer de tuer le monstre>(1), <Fuir>(2), <Agiter les bras comme un sauvage>(3)");
            while (int.TryParse(Console.ReadLine(), out choix) == false) ;
            if (choix == 1)
            {
                Enemy troll = new Enemy("Troll", 4, 2, 1);
                player.Attack(troll);
                Console.WriteLine("Mais en faisant des galipettes, vous vous êtes retouné un ongle..");
                Console.ReadKey();
                Console.WriteLine("Ça mérite quand même un coeur en moins...");
                player.LooseLife(1);
                Console.ReadKey();
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
                Console.ReadKey();
                Console.WriteLine("*ÉBOULEMENT*");
                Console.ReadKey();
                Console.WriteLine("Dans sa chute, l'éboulement emporte aussi la vie du vieux mineur...");
                Console.ReadKey();
                Text5(player);
            }
            else
            {
                Console.WriteLine("Bon c'est compliqué avec toi, aller je te réexplique");
                Console.ReadKey();
                Text4(player);
            }
        }
        public void Text41(Player player) //Sinon celle-ci se lance
        {
            Console.WriteLine("Vous prenez la fuite.");
            Console.ReadKey();
            Console.WriteLine("*ÉBOULEMENT*");
            Console.ReadKey();
            Console.WriteLine("Dans sa chute, l'éboulement emporte la vie du vieux mineur...");
            Console.ReadKey();
            Text5(player);
        }

        public void Text5(Player player)
        {
            int choix;
            Console.WriteLine("*LUMIÈRE ÉBLOUISSANTE*");
            Console.ReadKey();
            Console.WriteLine("Vous apercevez une lumière, certainement la sortie !");
            Console.ReadKey();
            Console.WriteLine("Que décidez-vous de faire ?");
            Console.ReadKey();
            Console.WriteLine("<Suivre la lumière>(1) (TRÈS FAVORABLE) ou <Retourner voir le mineur>(2) (MOINS FAVORABLE)");
            while (int.TryParse(Console.ReadLine(), out choix) == false) ;
            if (choix == 1)
            {
                FinalIntro();
            }
            else if (choix == 2)
            {
                Console.WriteLine("Je vous avais portant dis de pas y revenir");
                Console.ReadKey();
                player.Dead();
            }
            else
            {
                Console.WriteLine("T'es un cancre toi, aller on repart pour un explication de ce qui se passe");
                Console.ReadKey();
                Text5(player);
            }
        }
        public void FinalIntro()
        {
            Console.WriteLine("Vous êtes enfin sorti de là !");
            Console.ReadKey();
            Console.WriteLine("Vous apercevez d'un coté une rivière et de l'autre, de la fumée sûrement d'un ancien feu de camp.");
            Console.ReadKey();
            Console.WriteLine("Que decidez vous de faire ?");
            Console.ReadKey();
            Console.WriteLine("<Vers la rivière> ou <Vers la fumée>");
            Console.WriteLine("FIN DE LA DEMO GRATUITE");
            Console.ReadKey();
            System.Environment.Exit(0);
        }
    }
}
