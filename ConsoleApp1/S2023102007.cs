namespace ConsoleApp1;

public class S2023102007 {

    class Monster
    {
        public int id;

        public Monster(int id)
        {
            this.id = id;
        }
    }
    public static void Run()
    {
        // Dictionary
        Dictionary<int, Monster> dic = new Dictionary<int, Monster>();
        for (int i = 0; i < 10000; i++)
        {
            dic.Add(i,new Monster(i));
        }

        Monster mon;
        Console.WriteLine(dic.TryGetValue(7000, out mon));

        dic.Remove(7777);
        dic.Clear();
    }
}