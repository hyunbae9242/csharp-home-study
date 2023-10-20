namespace ConsoleApp1;

public enum MonsterType {
    None = 0,
    Slime = 1,
    Orc = 2,
    Skeleton = 3
}
public class Monster : Creature
{
    protected MonsterType type = MonsterType.None;

    protected Monster(MonsterType type) : base(CreatureType.Monster)
    {
        this.type = type;
    }

    public MonsterType GetMonsterType()
    {
        return type;
    }
}

public class Slime : Monster
{
    public Slime() : base(MonsterType.Slime)
    {
        Console.WriteLine("슬라임이 생성되었습니다!");
        SetInfo(10,10);
    }
}

public class Orc : Monster
{
    public Orc() : base(MonsterType.Orc)
    {
        Console.WriteLine("오크가 생성되었습니다!");
        SetInfo(20,15);
    }
}

public class Skeleton : Monster
{
    public Skeleton() : base(MonsterType.Skeleton)
    {
        Console.WriteLine("스켈레톤이 생성되었습니다!");
        SetInfo(15,20);
    }
}