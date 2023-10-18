namespace ConsoleApp1;

public class S2023101801 {

    // 객체(OOP Object Oriented Programming
    
    // Knight
    // 속성 : hp, attack
    // 기능 : Move, Attack, Die

    class Knight
    {
        public int hp;
        public int attack;

        public Knight()
        {
            hp = 100;
            attack = 10;
            Console.WriteLine("생성자 호출!");
        }

        public Knight(int hp) : this()
        {
            this.hp = hp;
            Console.WriteLine("hp 생성자 호출!");
        }

        public Knight(int hp, int attack) : this(hp)
        {
            this.attack = attack;
            Console.WriteLine("hp, attack 생성자 호출!");
        }

        public void Move()
        {
            Console.WriteLine("Knight Move");
        }

        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }

        public Knight Clone()
        {
            Knight knight = new();
            knight.hp = hp;
            knight.attack = attack;
            return knight;
        }
    }

    public static void Run()
    {
        Knight knight = new();
        Console.WriteLine(knight.hp);
        Console.WriteLine(knight.attack);
            
        knight.Move();
        knight.Attack();
        Knight knight2 = knight.Clone();

        Knight knight3 = new(50);
        Console.WriteLine(knight3.hp);

        Knight knight4 = new(50, 120);
        Console.WriteLine(knight4.hp);
        Console.WriteLine(knight4.attack);
    }
}