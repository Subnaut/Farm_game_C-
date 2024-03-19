public class Joueur : Entite
{
    private int Lvl_fourche;

    // Constructeur //  
    public Joueur(string Nom, int Vie, int Degat, Inventaire Sac, int Lvl_fourche):
    base (Nom, Vie, Degat, Sac)

    {
        this.Lvl_fourche = Lvl_fourche;
    }

    // Méthodes //  

    public int getLvl()
        {
        return this.Lvl_fourche;
        }
    public void addLvl()
        {
        this.Lvl_fourche += 1 
        }

}
    