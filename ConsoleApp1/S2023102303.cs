using System.Reflection;

namespace ConsoleApp1;

public class S2023102303
{

    static int Find()
    {
        return 0;
    }

    class Monster
    {
        public int id { get; set; }
    }
    public static void Run()
    {
        // Nullable - Null + able
        int? number = null;

        int b = number ?? 0;
        if (number != null)
        {
            
        }

        if (number.HasValue)
        {
            
        }
        number = 3;
        int a = number.Value;

        Monster monster = null;
        int? id = monster?.id;
    }
}