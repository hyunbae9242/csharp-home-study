namespace ConsoleApp1;

public class S2023102106
{
    enum ItemType
    {
        Weapon,
        Armor,
        Amulet,
        Ring
    }

    enum Rarity
    {
        
        Normal,
        Uncommon,
        Rare
    }

    class Item
    {
        public ItemType ItemType;
        public Rarity Rarity;
    }

    private static List<Item> _items = new List<Item>();

    static Item FindItem(Func<Item,bool> selector)
    {
        foreach (var item in _items)
        {
            if (selector(item))
                return item;
        }

        return null;
    }
    public static void Run()
    {
        // Lambda : 일회용 함수를 만드는데 사용하는 문법
        _items.Add(new Item(){ ItemType = ItemType.Weapon, Rarity = Rarity.Normal});
        _items.Add(new Item(){ ItemType = ItemType.Armor, Rarity = Rarity.Uncommon});
        _items.Add(new Item(){ ItemType = ItemType.Ring, Rarity = Rarity.Rare});

        // Anonymous Function 익명함수 , 무명함수!! 람다는 아니다.
        Item item = FindItem(delegate(Item item) { return item.ItemType == ItemType.Weapon; });
        Item item2 = FindItem(i =>  i.ItemType == ItemType.Weapon);
        
        // delegate 를 직접 선언하지 않아도 이미 만들어진 것들이 존재.
        // 반환 타입이 있을 경우 -> Func
        // 반환 타입이 없을 경우 -> Action
    }
}