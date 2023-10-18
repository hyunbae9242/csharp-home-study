namespace ConsoleApp1;

public class S2023101805 {

    // 객체(OOP Object Oriented Programming
    // 다형성
    // 부모 메소드에 virtual 을 붙혀두면 해당 실제 인스턴스의 override 한 메소드가 우선실행됨..
    // virtual 을 붙혀두었다고 해서 상속받았다고 무조건 override 를 하지 않아도 됨
    // 실제 인스턴스가 부모 인스턴스라면 virtual 의 함수가 실행됨.

    class Player
    {
        protected int hp;
        protected int attack;

        public virtual void Move()
        {
            Console.WriteLine("Player 이동");
        }
    }

    class Knight : Player
    {
        public override void Move()
        {
            base.Move();
            Console.WriteLine("Knight 이동");
        }
    }

    class Mage : Player
    {
        public override void Move()
        {
            Console.WriteLine("Mage 이동");
        }
    }

    static void EnterGame(Player player)
    {
        player.Move();
    }

    public static void Run()
    {
        Knight knight = new();
        Mage mage = new();
        Player player = new();
        
        EnterGame(knight);
        EnterGame(mage);
        EnterGame(player);
    }
}