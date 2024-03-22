using System;
public static class Combat
{

    // Méthodes //  

    public static void CombatRound(Joueur j, Entite e)
    {
        Console.WriteLine("Que voulez-vous faire ?");
        Console.WriteLine("1. Attaquer");
        Console.WriteLine("2. Se soigner");

        string choix = Console.ReadLine();

        switch (choix)
        {
            case "1":
                Attaquer(j, e);
                break;
            case "2":
                SeSoigner(j);
                break;
            default:
                Console.WriteLine("Choix invalide. Attaque par défaut.");
                Attaquer(j, e);
                break;
        }

        if (e is Entite)
        {
            if (new Random().Next(0, 2) == 0)
            {
                SeSoigner(e);
            }
            else
            {
                Attaquer(e, j);
            }
        }
    }

    private static void Attaquer(Entite attaquant, Entite cible)
    {
        int degats = attaquant.getDegat();
        int vieCible = cible.getVie();
        cible.setVie(vieCible - degats);
        Console.WriteLine($"{attaquant.getNom()} inflige {degats} dégâts à {cible.getNom()}");
        Console.WriteLine("");
    }

    private static void SeSoigner(Entite entite)
    {
        int amount = new Random().Next(5, 15); // Soins aléatoires entre 5 et 15
        int vieEntite = entite.getVie();
        entite.setVie(vieEntite + amount);
        Console.WriteLine($"{entite.getNom()} se soigne de {amount} points de vie.");
        Console.WriteLine("");
    }

}