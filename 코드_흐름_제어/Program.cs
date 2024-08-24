/*
 * 네임 스페이스 + 클래스와 메소드
 */

/*
 * 범위 지정
 * 
 * 범위의 시작 {
 * 
 * } 범위의 끝
 * 
 */

/* 
* 목표: 게임 시작 메뉴 만들기
* 1.게임 시작, 게임 종료
* 
* 
*/

using 코드_흐름_제어;

namespace 코드흐름제어
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartEnd start = new StartEnd();

            Console.WriteLine("C#강의 3번쨰 클래스");
            Console.WriteLine("반복문과 조건문");

            Console.WriteLine("실행할 강의를 선택해 주세요 (1.if문 2.switch문 2.for문 4.while문 5.게임메뉴예제) : ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                if조건문.Show(); //if문 강의 내용
            }
            else if (userInput == 2)
            {
                switch조건문.Show(); //switch문 강의 내용
            }
            else if (userInput == 3)
            {
                for반복문.Show(); //for 반복문 강의 내용
            }
            else if (userInput == 4)
            {
                while반복문.Show(); //while반복문 강의 내용
            }
            else if (userInput == 5)
            {
                start.Game();
            }

        }
    }
}