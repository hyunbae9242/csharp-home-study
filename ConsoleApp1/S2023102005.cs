namespace ConsoleApp1;

public class S2023102005 {

    class Map
    {
        private int[,] tiles =
        {
            { 1, 1, 1, 1, 1 },
            { 1, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 1 },
            { 1, 1, 1, 1, 1 }
        };

        public void Render()
        {
            for (int y = 0; y < tiles.GetLength(1); y++)
            {
                for (int x = 0; x < tiles.GetLength(0); x++)
                {
                    if (tiles[y, x] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write('\u25cf');    
                }

                Console.WriteLine();
            }
        }
    }
    
    public static void Run()
    {
        // 배열
        int[] scores = new int[] {50, 40, 30, 20, 10};
        
        // 2F [ , , ]
        // 1F [ , , ]
        int[,] arr = new int[2, 3];
        int[,] arr1 = new int[2, 3] { { 1, 2, 3 }, { 11, 22, 33 } };
        int[,] arr2 = { { 1, 2, 3 }, { 11, 22, 33 } };

        Map map = new Map();
        map.Render();
        
        // 가변 다차원배열
        // [ . . ]
        // [ . . . . ]
        // [ . . .]
        int[][] a = new int[3][];
        a[0] = new int[3];
        a[1] = new int[5];
        a[2] = new int[4];
    }
}