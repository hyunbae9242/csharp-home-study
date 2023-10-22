namespace ConsoleApp1;

public class S2023102104
{
    // 업체 사장과 통화.. - 사장님의 비서 연락 -> 연락처/용건 -> 연락을 달라고 요청

    // 함수 자체를 인자로 넘겨주는 형식
    // 반환:int 입력:void 
    // 반환형식과 입력형식이 같아야함!
    delegate int OnClicked();
    
    // UI 함수 자체를 인자로 넘겨주고 그 함수에선 넘겨받은 함수를 실행..
    static void ButtonPressed(OnClicked clickedFunction)
    {
        clickedFunction();
    }

    static int TestDelegate()
    {
        Console.WriteLine("hello Delegate");
        return 0;
    }
    
    static int TestDelegate2()
    {
        Console.WriteLine("hello Delegate 2");
        return 0;
    }
    
    public static void Run()
    {
        // Delegate (대리자)
        ButtonPressed(/* 함수를 넘겨준다! */ TestDelegate);

        OnClicked clicked = TestDelegate;
        clicked += TestDelegate2;
        ButtonPressed(clicked);
    }
}