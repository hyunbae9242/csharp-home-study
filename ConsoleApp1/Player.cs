namespace ConsoleApp1;

public enum PlayerType
{
    None = 0,
    Knight = 1,
    Archer = 2,
    Mage = 3
}

public class Player : Creature
{
    protected PlayerType type = PlayerType.None;
    
    protected Player(PlayerType type) : base(CreatureType.Player)
    {
        this.type = type;
    }
   
}

public class Knight : Player
{
    public Knight() : base(PlayerType.Knight)
    {
        SetInfo(100,10);
    }
}

public class Archer : Player
{
    public Archer() : base(PlayerType.Archer)
    {
        SetInfo(80,12);
    }
}

public class Mage : Player
{
    public Mage() : base(PlayerType.Mage)
    {
        SetInfo(60,15);
    }
}
