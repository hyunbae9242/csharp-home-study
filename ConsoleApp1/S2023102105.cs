namespace ConsoleApp1;

public class S2023102105
{

    private static void OnInputTest()
    {
        Console.WriteLine("input Received!");
    }
    public static void Run()
    {
        // Event (delegate 를 wrapping 하는 문법)
        InputManager inputManager = new InputManager();
        inputManager.InputKey += OnInputTest;
        while (true)
        {
            
            inputManager.Update();
        }
    }
}