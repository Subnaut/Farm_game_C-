public class Joueur 
{
    private int Lvl_fourche;

    // Constructeur //  
    public Joueur(string Nom, int Vie, int Degat, Inventaire Sac, int Lvl_fourche):
    base (Nom, Vie, Degat, Sac)

    {
        this.Lvl_fourche;
    }

    // Méthodes //  

    public int getLvl()
        {
        return this.Lvl_fourche;
        }
    

}
    