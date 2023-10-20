namespace ConsoleApp1;

public enum CreatureType
{
    None,
    Player = 1,
    Monster = 2
}
public class Creature
{
    protected CreatureType type = CreatureType.None;
    protected int hp = 0;
    protected int attack = 0;

    protected Creature(CreatureType type)
    {
        this.type = type;
    }
    
    public void SetInfo(int hp, int attack)
    {
        this.hp = hp;
        this.attack = attack;
    }
    
    public int GetHp()
    {
        return this.hp;
    }

    public int GetAttack()
    {
        return this.attack;
    }

    public bool IsDead()
    {
        return hp <= 0;
    }

    public void OnDamaged(int damage)
    {
        hp -= damage;
        if (hp < 0) hp = 0;
    }
}