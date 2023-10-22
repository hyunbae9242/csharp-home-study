namespace ConsoleApp1;

public class S2023102103
{
    // 객체지향 -> 은닉성
    class Knight
    {
        private int hp;

        public int Hp
        {
            get { return hp; }
            // protected set { hp = value; } 접근제한자 붙히기 가능
            set { hp = value; }
        }
    }

    // 위와 같음...
    class Archer
    {
        public int Hp { get; set; } = 100; // 기본초기화도 가능
    }
    public static void Run()
    {
        // property
        Knight knight = new Knight();
        knight.Hp = 100;
        int hp = knight.Hp;
        Console.WriteLine(hp);

        Archer archer = new Archer();
        Console.WriteLine(archer.Hp);
        archer.Hp = 80;
        int archerHp = archer.Hp;
        Console.WriteLine(archerHp);
    }
}