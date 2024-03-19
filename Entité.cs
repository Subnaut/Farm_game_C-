public class Entité 
{
    private string Nom;
    private int Vie;
    private int Degat;
    private Inventaire Sac;

    // Constructeur //  
    public Entité(string Nom, int Vie, int Degat, Inventaire Sac)

    {
        this.Nom = Nom;
        this.Vie = Vie;
        this.Degat = Degat;
        this.Sac = Sac;
    }

    // Méthodes //  

    public int getNom()
        {
        return this.Nom;
        }
    public int getVie()
        {
        return this.Vie;
        }
    public int getDegat()
        {
        return this.Degat;
        }
    public int getVie()
        {
        return this.Vie;
        }

}
