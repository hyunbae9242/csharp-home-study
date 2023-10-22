namespace ConsoleApp1;

public class S2023102101
{

    class Monster
    {
        
    }
    class MyList<T> where T: Monster
    {
        private T[] arr = new T[10];

        public T GetItem(int i)
        {
            return arr[i];
        }
    }

    static void  Test<T>(T t)
    {
        Console.WriteLine(t);
    }
    
    public static void Run()
    {
        // 제네릭
        // MyList<int> myIntList = new MyList<int>();
        // MyList<string> myStringList = new MyList<string>();
        MyList<Monster> myMonsterList = new MyList<Monster>();
        Test(1);
    }
}