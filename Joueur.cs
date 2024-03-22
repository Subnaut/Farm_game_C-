public class Joueur : Entite
{
    private int Lvl_fourche;

    // Constructeur //  
    public Joueur(string Nom, int Vie, int Degat, int Argent_E, int Lvl_fourche):
    base (Nom, Vie, Degat, Argent_E)

    {
        this.Lvl_fourche = Lvl_fourche;
    }

    // Méthodes //  

    public int getLvl()
        {
        return this.Lvl_fourche;
        }
    public void setLvl(int lvl)
        {
        // Augmente le niveau de la fourche
        this.Lvl_fourche = lvl;
        }
    public override int getDegat()
    {
        // Augmente les dégâts en fonction du niveau de fourche
        int degats = base.getDegat();
        int bonus = (this.Lvl_fourche) * 2; // Chaque niveau ajoute 2 degat de bonus
        return degats + bonus;
    }

}