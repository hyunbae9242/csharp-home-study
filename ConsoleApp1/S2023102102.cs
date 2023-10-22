namespace ConsoleApp1;

public class S2023102102
{
    abstract class Monster
    {

        public abstract void Shout();
    }

    interface IFlyable
    {
        void Fly();
    }

    interface ITest
    {
        void Test();
    }

    class Orc : Monster
    {
        public override void Shout()
        {
            Console.WriteLine("꾸어어어!");
        }
    }

    class FlyableOrc : Orc, IFlyable, ITest
    {
        public void Fly()
        {
            Console.WriteLine("날아오르라 주작이여!");
        }

        public void Test()
        {
            Console.WriteLine("TEST !!");
        }
    }


    class Skeleton : Monster
    {
        public override void Shout()
        {
            Console.WriteLine("크르렁!");
        }
    }

    static void DoFly(IFlyable ifFlyable)
    {
        ifFlyable.Fly();
    }
    public static void Run()
    {
        // 추상화
        Orc orc = new Orc();
        orc.Shout();

        FlyableOrc flyableOrc = new FlyableOrc();
        flyableOrc.Fly();
        DoFly(flyableOrc);
        flyableOrc.Shout();
        flyableOrc.Test();
    }
}