public class Inventaire
{
    private List<Item> inventaire;

    // Constructeur //  
    public Inventaire(List<Item> inventaire)

    {
        this.inventaire = new List<Item>();
    }
    
    // Méthodes //  
    
    public List<Item> getInv()
        {
        return this.inventaire;
        }
    

}

    