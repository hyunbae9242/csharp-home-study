namespace ConsoleApp1;

public class S2023101804 {

    // 객체(OOP Object Oriented Programming

    class Player
    {
        protected int hp;
        protected int attack;
    }
    
    class Knight : Player
    {
        
    }

    class Mage : Player
    {
        public int mp;
    }

    static void EnterGame(Player player)
    {
        if (player is Mage)
        {
            Mage mage = (Mage)player;
            mage.mp = 100;
        }

        Mage mage1 = player as Mage;
        if (mage1 != null)
        {
            mage1.mp = 100;
        }
        

    }

    public static void Run()
    {
        Knight knight = new();
        Mage mage = new();
        
        EnterGame(knight); // <- 여기서 런타임오류!
        EnterGame(mage);
    }
}