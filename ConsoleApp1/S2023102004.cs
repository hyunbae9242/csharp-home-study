namespace ConsoleApp1;

public class S2023102004 {

    static int GetHighestScore(int[] scores)
    {
        int temp = 0;
        foreach (var i in scores)
        {
            if (i > temp) temp = i;
        }
        return temp;
    }

    static int GetAverageScore(int[] scores)
    {
        if (scores.Length == 0) return 0;
        int sum = 0;
        foreach (var i in scores)
        {
            sum += i;
        }

        return sum == 0 ? 0 : sum / scores.Length;
    }

    static int GetIndexOf(int[] scores, int value)
    {
        int index = 0;
        foreach (var i in scores)
        {
            if (i == value) return index;
            index++;
        }
        return -1;
    }

    static void Sort(int[] scores)
    {
        for (int i = 0; i < scores.Length; i++)
        {
            for (int j = i + 1; j < scores.Length; j++)
            {
                if (scores[i] > scores[j])
                {
                    int temp = scores[i];
                    scores[i] = scores[j];
                    scores[j] = temp;
                }
            }
        }
    }
    
    public static void Run()
    {
        // 배열
        int[] scores = new int[] {50, 40, 30, 20, 10, 23 ,29, 95, 39, 239, 349,9, 49563,1, 23};
        // foreach (var i in scores)
        // {
        //     Console.WriteLine(i);
        // }
        // Console.WriteLine();
        // Console.WriteLine(GetHighestScore(scores));
        // Console.WriteLine();
        // Console.WriteLine(GetAverageScore(scores));
        // Console.WriteLine();
        // Console.WriteLine(GetIndexOf(scores, 20));
        // Console.WriteLine();
        Sort(scores);
        foreach (var i in scores)
        {
            Console.WriteLine(i);
        }

    }
}