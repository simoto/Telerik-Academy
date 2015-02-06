public class Chef
{
    public void Cook()
    {
        Potato potato = GetPotato();        
        Peel(potato);                       
        Cut(potato);

        Carrot carrot = GetCarrot();
        Peel(carrot);
        Cut(carrot);

        Bowl bowl = GetBowl();
        bowl.Add(potato);
        bowl.Add(carrot);        
    }
	
    private Bowl GetBowl()
    {   
        //... 
    }
	
    private Carrot GetCarrot()
    {
        //...
    }
	
    private Potato GetPotato()
    {
        //...
    }
	
    private void Peel(Vegetable vegetable)
    {

    }
	
    private void Cut(Vegetable vegetable)
    {
        //...
    }     
}


