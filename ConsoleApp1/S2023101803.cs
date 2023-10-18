namespace ConsoleApp1;

public class S2023101803 {

    // 객체(OOP Object Oriented Programming
    // 은닉성 

    class Knight
    {
        // private int hp; // 앞에 아무것도 붙히지 않으면 default : private 임
        protected int hp; // 상속을 받는 자식 클래스에서 접근가능하다.
        // public void SetHp(int hp)
        // {
        //     this.hp = hp;
        // }
    }

    class SuperKnight : Knight
    {
        public void SetHp(int hp)
        {
            this.hp = hp;
        }
    }
    

    public static void Run()
    {
        Knight knight = new Knight();
        // knight.hp = 1; private 일땐 외부에서 접근 불가능
        // knight.SecretFunction();
        // knight.SetHp(100); C#만의 문법이 있다네..
    }
}