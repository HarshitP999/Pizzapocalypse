
public  interface ICharacter 
{
    void Accept(IPowerUpPickup pickup);
}

public interface IPowerUpPickup
{
    void Pick(Pelayr player);
    void Pick(Enamy enemy);
}