public class Item
{
    private string Nom_item;
    private int Prix;

    // Constructeur //  
    public Item(string Nom_item, int Prix)

    {
        this.Nom_item = Nom_item;
        this.Prix = Prix;
    }

    // Méthodes //  
    public int getNom_item()
        {
        return this.Nom_item;
        }
    
    public int getPrix()
        {
        return this.Prix;
        }

}

    