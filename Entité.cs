public class Entite 
{
    private string Nom;
    private int Vie;
    private int Degat;
    private int Argent_E;

    // Constructeur //  
    public Entite(string Nom, int Vie, int Degat, int Argent_E)

    {
        this.Nom = Nom;
        this.Vie = Vie;
        this.Degat = Degat;
        this.Argent_E = Argent_E;
    }

    // Méthodes //  

    public string getNom()
        {
        return this.Nom;
        }
    public int getVie()
        {
        return this.Vie;
        }
    public virtual int getDegat()
        {
        return this.Degat;
        }
    public void setVie(int v)
        {
        this.Vie = v;
        }
    public int getArgent_E()
        {
        return this.Argent_E;
        }

}