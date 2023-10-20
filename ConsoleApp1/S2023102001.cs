namespace ConsoleApp1;

public class S2023102001 {

    public static void Run()
    {
        string name = "Harry Potter";
        
        // 1. 찾기
        bool found = name.Contains("Harry");
        Console.WriteLine(found);
        int index = name.IndexOf('z');
        Console.WriteLine(index);
        
        // 2. 변형
        name = name + " Junior";
        Console.WriteLine(name);
        Console.WriteLine(name.ToLower());
        Console.WriteLine(name.ToUpper());
        Console.WriteLine(name.Replace('r','l'));
        
        // 3. 분할
        string[] names = name.Split(new char[]{ ' '});
        Console.WriteLine(name.Substring(5));
        Console.WriteLine(name.Substring(5,10));
    }
}