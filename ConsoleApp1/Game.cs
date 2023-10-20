namespace ConsoleApp1;

public enum GameMode
{
    None,
    Lobby,
    Town,
    Field,
    Exit
}

public class Game
{
    private GameMode mode = GameMode.Lobby;
    private Player player = null;
    private Monster monster = null;

    public bool isExit()
    {
        return GameMode.Exit.Equals(mode);}

    private static Random random = new Random();

    public void Process()
    {
        switch (mode)
        {
            case GameMode.Lobby:
                ProcessLobby();
                break;
            case GameMode.Town:
                ProcessTown();
                break;
            case GameMode.Field:
                ProcessField();
                break;
            case GameMode.Exit:
                break;
        }
    }

    private void ProcessLobby()
    {
        Console.Clear();
        Console.WriteLine("직업을 선택하세요!");
        Console.WriteLine("[1] 기사");
        Console.WriteLine("[2] 궁수");
        Console.WriteLine("[3] 법사");
        Console.WriteLine("[4] 게임 종료!");

        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
                player = new Knight();
                mode = GameMode.Town;
                break;
            case "2":
                player = new Archer();
                mode = GameMode.Town;
                break;
            case "3":
                player = new Mage();
                mode = GameMode.Town;
                break;
            case "4" :
                mode = GameMode.Exit;
                break;
        }
    }

    private void ProcessTown()
    {
        Console.Clear();
        Console.WriteLine("마을에 입장했습니다!");
        Console.WriteLine("[1] 필드로 가기");
        Console.WriteLine("[2] 로비로 돌아가기");
        
        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
                mode = GameMode.Field;
                ProcessField();
                break;
            case "2":
                mode = GameMode.Lobby;
                break;
        }
    }

    private void ProcessField()
    {
        Console.Clear();
        Console.WriteLine("필드에 입장했습니다!");
        Console.WriteLine("[1] 싸우기");
        Console.WriteLine("[2] 일정확률로 마을 돌아가기");

        CreateRandomMonster();

        string input = Console.ReadLine();
        switch (input)
        {
            case "1" :
                ProcessFight();
                break;
            case "2" :
                TryEscape();
                break;
        }
    }

    private void CreateRandomMonster()
    {
        int randValue = random.Next(0, 3);
        switch (randValue)
        {
            case 0 :
                monster = new Slime();
                break;
            case 1 :
                monster = new Orc();
                break;
            case 2 :
                monster = new Skeleton();
                break;
        }
    }

    private void ProcessFight()
    {
        while (true)
        {
            int damage = player.GetAttack();
            monster.OnDamaged(damage);
            if (monster.IsDead())
            {
                Console.WriteLine("승리!");
                Console.WriteLine($"남은 체력{player.GetHp()}");
                Console.WriteLine("필드로 돌아가는중..");
                Console.WriteLine("3...");
                Thread.Sleep(1000);
                Console.WriteLine("2...");
                Thread.Sleep(1000);
                Console.WriteLine("1...");
                Thread.Sleep(1000);
                break;
            }

            damage = monster.GetAttack();
            player.OnDamaged(damage);
            if (player.IsDead())
            {
                Console.WriteLine("패배....");
                mode = GameMode.Lobby;
                Console.WriteLine("로비로 돌아가는중..");
                Console.WriteLine("3...");
                Thread.Sleep(1000);
                Console.WriteLine("2...");
                Thread.Sleep(1000);
                Console.WriteLine("1...");
                Thread.Sleep(1000);
                break;
            }

        }
    }

    private void TryEscape()
    {
        int randValue = random.Next(0, 101);
        if (randValue <= 33) mode = GameMode.Town;
        else ProcessFight();
    }
}