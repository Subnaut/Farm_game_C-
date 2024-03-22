using System;
public class Grange 
{
    private int Argent;
    private int Jours_restant;
    private int Fixed; 

    // Constructeur //  
    public Grange(int Argent, int Jours_restant)

    {
        this.Argent = Argent;
        this.Jours_restant = Jours_restant;
        this.Fixed = 0;
    }

    // Méthodes //  

    public int getArgent()
        {
        return this.Argent;
        }
    
    public int getJours_restant()
        {
        return this.Jours_restant;
        }
    public int getFixed()
        {
        return this.Fixed;
        }
    public void setFixed(int i)
        {
        this.Fixed = i;
        }
    public void minus_Jour()
        {
        this.Jours_restant-=1;
        }
    public void addArgent(int amount)
        {
        this.Argent += amount;
        }
    public void suppArgent(int amount)
        {
        this.Argent -= amount;
        }
    public void marchand(Joueur j)
        {
        Console.WriteLine($"Vous avez :{this.getArgent()}$");
        Console.WriteLine("Que voulez-vous acheter ?");
        Console.WriteLine("Faites attention a ne pas racheter la même chose 2 fois !");
        Console.WriteLine("1. Améliorer la fourche au lvl 2 ? :50$");
        Console.WriteLine("2. Améliorer la fourche au lvl 3 ? :100$");
        Console.WriteLine("3. Réparer la grange ? :1000$");

        string choix = Console.ReadLine();

        switch (choix)
        {
            case "1":
                j.setLvl(2);
                this.Argent -= 200;
                break;
            case "2":
                j.setLvl(3);
                this.Argent -= 400;
                break;
            case "3":
                this.setFixed(1);
                this.Argent -= 5000;
                break;
            default:
                Console.WriteLine("Choix invalide.");
                break;
        }
        Console.WriteLine($"Il vous reste :{this.getArgent()}$");
        Console.WriteLine($"Votre fourche est lvl:{j.getLvl()}");
        Console.WriteLine("");

        this.minus_Jour();
        Console.WriteLine($"{j.getNom()} rentre chez lui pour une bonne nuit de repos. Une nouvelle journée commence.");
        Console.WriteLine($"Il vous reste {this.getJours_restant()} jours pour réparer la grange.");
        Console.WriteLine("");
        }

}  