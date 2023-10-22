namespace ConsoleApp1;

public class InputManager
{
    // Observer Pattern
    public delegate void OnInputKey();

    public event OnInputKey InputKey;
    
    public void Update()
    {
        if (Console.KeyAvailable == false)
        {
            return;
        }

        ConsoleKeyInfo info = Console.ReadKey();
        if (info.Key == ConsoleKey.A)
        {
            // 모두에게 알린다!
            InputKey();
        }
    }
}