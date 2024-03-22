using System;
using System.Collections.Generic;
class Programe
{
    static void Main(string[] args)
    {
     //Def objets//   
     Grange grange;
     grange = new Grange(0, 5);
    
     
     //-----------------Setup_Joueur-----------------------//

     Joueur fermier;
     fermier = new Joueur("Bob",100,10,0,1);
     //----------------------------------------------------//

     //-----------------PLantes-----------------------//

     Entite P1;
     P1 = new Entite("Fleur mutante",50,5,150);

     Entite P2;
     P2 = new Entite("Choux mutant",70,3,210);

     Entite P3;
     P3 = new Entite("Carotte mutante",65,7,300);

     Entite P4;
     P4 = new Entite("Pois géant mutant",70,5,380);

     Entite P5;
     P5 = new Entite("Roi Patate mutant",200,9,10000);

     //-----------------------------------------------//
     
     //-----------------Intro-----------------------//
     Console.WriteLine($"Alors que le fermier {fermier.getNom()} travaillait dans son champ, des monstres plantes ont commencé à l'attaquer.");
     Console.WriteLine("Ils ont fini par détruire sa grange !");
     Console.WriteLine("Bob n'a plus qu'un nombre limité de jours pour la réparer et reprendre son activité, sinon il perdra tout.");
     Console.WriteLine($"Jours restant :{grange.getJours_restant()}");
     Console.WriteLine("");

     //-----------------------------------------------//
     
     //-----------------1er_Combat-----------------------//

     Console.WriteLine($"En essayant de travailler dans son champ {fermier.getNom()} se fait attaquer :");
     Console.WriteLine("");

     while (fermier.getVie() > 0 && P1.getVie() > 0)
        {
            Combat.CombatRound(fermier, P1);
            Console.WriteLine($"{fermier.getNom()} : Vie restante = {fermier.getVie()}");
            Console.WriteLine($"{P1.getNom()} : Vie restante = {P1.getVie()}");
            Console.WriteLine();
        }

     if (fermier.getVie() <= 0)
        {
            Console.WriteLine("Le joueur a perdu !");
            fermier.setVie(100);
        }
     else if (P1.getVie() <= 0)
        {
            Console.WriteLine("Le joueur a vaincu le monstre !");
            grange.addArgent(P1.getArgent_E());
            
        }
     //-----------------------------------------------//

     Console.WriteLine("");
     Console.WriteLine($"{fermier.getNom()} fait un détour par le magasin de son amie marchande, c'est elle qui par la même occasion pourra vous trouver quelqu'un pour réparer sa grange");
     Console.WriteLine($"Elle vend des outils bien solide qui devrait être utile à {fermier.getNom()}. Il décide donc de passer au magasin tous les soirs.");
     Console.WriteLine("");
     grange.marchand(fermier);

     //-----------------2e_Combat-----------------------//

     Console.WriteLine($"Ce coup-ci {fermier.getNom()} se doute qu'il va se faire attaquer il se tient donc pret avec ça fourche de niveau {fermier.getLvl()} :");
     Console.WriteLine("");

     while (fermier.getVie() > 0 && P2.getVie() > 0)
        {
            Combat.CombatRound(fermier, P2);
            Console.WriteLine($"{fermier.getNom()} : Vie restante = {fermier.getVie()}");
            Console.WriteLine($"{P2.getNom()} : Vie restante = {P2.getVie()}");
            Console.WriteLine();
        }

     if (fermier.getVie() <= 0)
        {
            Console.WriteLine("Le joueur a perdu !");
            fermier.setVie(100);
        }
     else if (P2.getVie() <= 0)
        {
            Console.WriteLine("Le joueur a vaincu le monstre !");
            grange.addArgent(P2.getArgent_E());
            
        }
     //-----------------------------------------------//
     Console.WriteLine($"{fermier.getNom()} retourne au magasin :");
     grange.marchand(fermier);

     //-----------------3e_Combat-----------------------//

     Console.WriteLine($"Ce coup-ci {fermier.getNom()} se doute qu'il va se faire attaquer il se tient donc pret avec ça fourche de niveau {fermier.getLvl()} :");
     Console.WriteLine("");

     while (fermier.getVie() > 0 && P3.getVie() > 0)
        {
            Combat.CombatRound(fermier, P3);
            Console.WriteLine($"{fermier.getNom()} : Vie restante = {fermier.getVie()}");
            Console.WriteLine($"{P3.getNom()} : Vie restante = {P3.getVie()}");
            Console.WriteLine();
        }

     if (fermier.getVie() <= 0)
        {
            Console.WriteLine("Le joueur a perdu !");
            fermier.setVie(100);
        }
     else if (P3.getVie() <= 0)
        {
            Console.WriteLine("Le joueur a vaincu le monstre !");
            grange.addArgent(P3.getArgent_E());
            
        }
     //-----------------------------------------------//
     Console.WriteLine($"{fermier.getNom()} retourne au magasin :");
     grange.marchand(fermier);

     //-----------------4e_Combat-----------------------//

     Console.WriteLine($"Ce coup-ci {fermier.getNom()} se doute qu'il va se faire attaquer il se tient donc pret avec ça fourche de niveau {fermier.getLvl()} :");
     Console.WriteLine("");

     while (fermier.getVie() > 0 && P4.getVie() > 0)
        {
            Combat.CombatRound(fermier, P4);
            Console.WriteLine($"{fermier.getNom()} : Vie restante = {fermier.getVie()}");
            Console.WriteLine($"{P4.getNom()} : Vie restante = {P4.getVie()}");
            Console.WriteLine();
        }

     if (fermier.getVie() <= 0)
        {
            Console.WriteLine("Le joueur a perdu !");
            fermier.setVie(100);
        }
     else if (P4.getVie() <= 0)
        {
            Console.WriteLine("Le joueur a vaincu le monstre !");
            grange.addArgent(P4.getArgent_E());
            
        }
     //-----------------------------------------------//
     Console.WriteLine($"{fermier.getNom()} retourne au magasin :");
     grange.marchand(fermier);

     //-----------------5e_Combat-----------------------//

     Console.WriteLine($"Ce coup-ci ce n'est pas un simple monstre qui attaque {fermier.getNom()} mais le roi Patate. {fermier.getNom()} ne peut donc que commencer a se battre avec sa fourche de niveau {fermier.getLvl()} :");
     Console.WriteLine("");

     while (fermier.getVie() > 0 && P5.getVie() > 0)
        {
            Combat.CombatRound(fermier, P5);
            Console.WriteLine($"{fermier.getNom()} : Vie restante = {fermier.getVie()}");
            Console.WriteLine($"{P5.getNom()} : Vie restante = {P5.getVie()}");
            Console.WriteLine();
        }

     if (fermier.getVie() <= 0)
        {
            Console.WriteLine("Le joueur a perdu !");
            fermier.setVie(100);
        }
     else if (P2.getVie() <= 0)
        {
            Console.WriteLine("Le joueur a vaincu le monstre !");
            grange.addArgent(P5.getArgent_E());
            
        }
     //-----------------------------------------------//
     Console.WriteLine($"{fermier.getNom()} retourne au magasin :");
     grange.marchand(fermier);
     Console.WriteLine("");

     if (grange.getFixed() == 0)
        {
            Console.WriteLine($"{fermier.getNom()} n'a pas réussi à réparer sa grange.");
            Console.WriteLine("10 jours plus tard il sera engagé dans le magasin de son amie. Sa ferme lui manque");
            Console.WriteLine($"A la fin il lui reste {grange.getArgent()}$ et une fourche lvl{fermier.getLvl()}");
        }
    else
        {
            Console.WriteLine($"{fermier.getNom()} a réussi à réparer sa grange.");
            Console.WriteLine("Il continue de temps en temps à tomber sur des plantes mutantes mais arrive facilement à sen débarrasser");
            Console.WriteLine($"A la fin il lui reste une grange neuve, {grange.getArgent()}$ et une fourche lvl{fermier.getLvl()}");
        }


    Console.WriteLine("");
    Console.WriteLine("Fin du jeux");
    string Fin = Console.ReadLine();
    }
}