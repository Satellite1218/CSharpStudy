namespace 클래스와_메소드
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            NameSpace ns = new NameSpace();
            ns.Show();

            while (true)
            {
                Console.WriteLine("1. 공격한다");
                Console.WriteLine("2. 휴식한다");
                Console.WriteLine("유저의 행동을 입력해 주세요");
                int userInput = int.Parse(Console.ReadLine());
                if (userInput == 1)
                {
                    //player attack(slime);
                }
                else if(userInput == 2)
                {
                    //player.Rest();
                }
            }
        }
    }
}
