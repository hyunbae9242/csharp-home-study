namespace ConsoleApp1;

public class S2023101802 {

// 객체(OOP Object Oriented Programming
    // 은닉성 / 상속성 / 다형성
    class Player
    {
        public int hp;
        public int attack;

        public Player()
        {
            Console.WriteLine("Player 생성자호출");
        }
        
        public Player(int hp, int attack)
        {
            Console.WriteLine("Player hp,attack 생성자호출");
            this.hp = hp;
            this.attack = attack;
        }
    }

    class Mage : Player
    {
        public Mage()
        {
            Console.WriteLine("Mage 생성자호출");
        }

        public Mage(int hp, int attack) : base(hp, attack)
        {
            Console.WriteLine("Mage hp, attack 생성자 호출");
        }
    }

    class Archer : Player
    {
        
    }

    public static void Run()
    {
        Mage mage = new();
        Mage mage1 = new(1000, 150);
    }
}