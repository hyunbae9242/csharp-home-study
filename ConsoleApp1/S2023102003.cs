namespace ConsoleApp1;

public class S2023102003 {

    class Player
    {
        
    }

    class Monster
    {
        
    }
    public static void Run()
    {
        // 배열
        // int[] scores = new int[5] {10, 20, 30, 40, 50}; // 기본
        // int[] scores = new int[] {10, 20, 30, 40, 50}; // 숫자가 빠짐
        int[] scores = {10, 20, 30, 40, 50}; // 이니셜라이져가 빠짐
        // 0 1 2 3 4
        // scores[0] = 10;
        // scores[1] = 20;
        // scores[2] = 30;
        // scores[3] = 40;
        // scores[4] = 50;
        for (int i = 0; i < scores.Length ; i++)
        {
            Console.WriteLine(scores[i]);
        }

        foreach (int score in scores)
        {
            Console.WriteLine(score);
        }

    }
}