namespace ConsoleApp1;

public class S2023102002 {

    public static void Run()
    {
        Game game = new Game();

        while (true)
        {
            game.Process();
            if (game.isExit()) break;
        }

        Console.WriteLine("게임을 종료합니다");
    }
}