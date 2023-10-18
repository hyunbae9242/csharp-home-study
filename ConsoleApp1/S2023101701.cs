namespace ConsoleApp1;


public class S2023101701 {

    enum JobType
    {
        None = 0,
        Warrior = 1,
        Archer = 2,
        Wizard = 3
    }

    struct Player
    {
        public JobType jobType;
        public int maxHp;
        public int attack;
    }

    enum MonsterType
    {
        None = 0,
        Slime = 1,
        Orc = 2,
        Skeleton = 3
    }

    struct Monster
    {
        public MonsterType MonsterType;
        public int maxHp;
        public int attack;
    }
    
    static void ChoseJob(out JobType jobType)
    {
        jobType = JobType.None;
        while (jobType == JobType.None)
        {
            Console.WriteLine("직업을 선택하세요!");
            Console.WriteLine("1 : 전사");
            Console.WriteLine("2 : 궁수");
            Console.WriteLine("3 : 법사");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    jobType = JobType.Warrior;
                    break;
                case "2":
                    jobType = JobType.Archer;
                    break;
                case "3":
                    jobType = JobType.Wizard;
                    break;
                default:
                    jobType = JobType.None;
                    break;
            }
        }
    }

    static void PlayerSetting(JobType jobType,out int maxHp, out int attack)
    {
        switch (jobType)
        {
            case JobType.Warrior:
                maxHp = 100;
                attack = 10;
                break;
            case JobType.Archer:
                maxHp = 80;
                attack = 12;
                break;
            case JobType.Wizard:
                maxHp = 50;
                attack = 15;
                break;
            default:
                maxHp = 0;
                attack = 0;
                break;
        }
    }

    static void CreateRandomMonster(out Monster monster)
    {
        Random rand = new Random();
        int random = rand.Next(1, 4);
        switch (random)
        {
            case (int) MonsterType.Slime:
                Console.WriteLine("슬라임이 스폰되었습니다!");
                monster.MonsterType = MonsterType.Slime;
                monster.maxHp = 20;
                monster.attack = 2;
                break;
            case (int) MonsterType.Orc:
                Console.WriteLine("오크가 스폰되었습니다!");
                monster.MonsterType = MonsterType.Orc;
                monster.maxHp = 40;
                monster.attack = 4;
                break;
            case (int) MonsterType.Skeleton:
                Console.WriteLine("스켈레톤이 스폰되었습니다!");
                monster.MonsterType = MonsterType.Skeleton;
                monster.maxHp = 30;
                monster.attack = 3;
                break;
            default:
                monster.MonsterType = MonsterType.None;
                monster.maxHp = 0;
                monster.attack = 0;
                break;
        }
    }

    static void EnterGame(ref Player player)
    {
        while (true)
        {
            Console.WriteLine("마을에 진입했습니다!");
            Console.WriteLine("[1] 필드로 간다");
            Console.WriteLine("[2] 로비로 돌아가기");

            string input = Console.ReadLine();
            if ("1".Equals(input))
            {
                EnterField(ref player);
            }else if ("2".Equals(input))
            {
                break;
            }
        }
    }

    static void EnterField(ref Player player)
    {
        while (true)
        {
            Console.WriteLine("필드에 접속했습니다!");
            // 몬스터 생성
            Monster monster;
            CreateRandomMonster(out monster);
            Console.WriteLine($"type : {monster.MonsterType}, hp : {monster.maxHp}, attack : {monster.attack}");
        
            Console.WriteLine("[1] 전투모드로 돌입");
            Console.WriteLine("[2] 일정확률로 마을로 도망가기");
            string input = Console.ReadLine();
            if ("1".Equals(input))
            {
                Fight(ref player, ref monster);
            }
            else if ("2".Equals(input))
            {
                // 33% 확률
                Random rand = new Random();
                int randValue = rand.Next(0, 101);
                if (randValue <= 33)
                {
                    Console.WriteLine("도망치는데 성공했습니다.");
                    break;
                }
                else
                {
                    Fight(ref player, ref monster);
                }
            }
        }
    }

    static void Fight(ref Player player, ref Monster monster)
    {
        while (true)
        {
            // 플레이어 -> 몬스터 공격
            monster.maxHp -= player.attack;
            if (monster.maxHp <= 0)
            {
                Console.WriteLine("승리했습니다!");
                Console.WriteLine($"남은 HP{player.maxHp}");
                break;
            }
            // 몬스터 -> 플레이어 공격
            player.maxHp -= monster.attack;
            if (player.maxHp <= 0)
            {
                Console.WriteLine("패배했습니다!");
                break;
            }
        }
    }
    
    public static void Run()
    {
        while (true)
        {
            Player player;
            // 직업선택
            ChoseJob(out player.jobType);
            // 직업에 따른 스텟 설정
            PlayerSetting(player.jobType, out player.maxHp, out player.attack);
            Console.WriteLine($"job : {player.jobType}, maxHp : {player.maxHp}, attack : {player.attack}");
            // 접속
            EnterGame(ref player);
        }
    }
}