namespace ConsoleApp1;

public class S2023102301
{
    class TestException : Exception
    {
        
    }
    public static void Run()
    {
        // 예외처리
        // 1. 0으로 나눌 때
        // 2. 잘못된 메모리를 참조 (null
        // 3. 오버플로우
        try
        {
            // int a = 10;
            // int b = 0;
            // int result = a / b;
            throw new TestException();
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("나누기 에러!");
        }
        catch (Exception e)
        {
            Console.WriteLine("어떤 애러니?");
            Console.WriteLine(e.Message);
        }
        finally
        {
            // 예외발생 후에도 실행이 되어야 할때
            Console.WriteLine("finally 실행됨!");
        }
    }
}