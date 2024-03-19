public class Inventaire
{
    private Item[] liste_Item = new Item[100];

    // Méthodes //  

    public void ajoutItem(Item item)
    {
        for (int i=0;i<this.liste_Item.Length;i++)
        {
            if (this.produits[i] != null)
            {
                continue;
            }
            else {
                this.produits[i] = prod;
                break;
            }
        
            }
    }
    
    public int getArgent()
        {
        return this.Argent;
        }
    
    public int getJours_restant()
        {
        return this.Jours_restant;
        }

}

    