namespace ConsoleApp1;

public class S2023102006 {

    public static void Run()
    {
        // list <- 동적 배열
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(3);
        list.Add(3);
        list.Add(3);
        list.Add(3);
        for (int k = 0; k < 5; k++)
        {
            Console.WriteLine(list[k]);
        }
        list.Insert(2,100);

        list.Remove(3);
        foreach (var i in list)
        {
            Console.WriteLine(i);
        }
        list.Clear();

    }
}