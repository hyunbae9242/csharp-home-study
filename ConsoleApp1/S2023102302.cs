using System.Reflection;

namespace ConsoleApp1;

public class S2023102302
{

    class Important : System.Attribute
    {
        private string message;

        public Important(string message)
        {
            this.message = message;
        }
    }
    class Monster
    {
        // hp입니다. 중요한 정보입니다.
        [Important("important message")]
        public int hp;
        protected int attack;
        private float speed;
        
        void Attack(){}
    }
    public static void Run()
    {
        // reflection 리플렉션! : X-Ray
        Monster monster = new Monster();

        Type type = monster.GetType();
        var fields = type.GetFields(BindingFlags.Public 
                      | BindingFlags.NonPublic 
                      | BindingFlags.Static 
                      | BindingFlags.Instance);
        foreach (var field in fields)
        {
            string access = "protected";
            if (field.IsPublic)
                access = "public";
            else if (field.IsPrivate)
                access = "private";

            var attributes = field.GetCustomAttributes();
            Console.WriteLine($"{access} {field.FieldType.Name} {field.Name}");
            
        }
    }
}