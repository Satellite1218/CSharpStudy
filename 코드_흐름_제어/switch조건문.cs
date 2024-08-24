using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 코드_흐름_제어
{
    enum USERINPUT
    {
        GAMESTART = 1,
        GAMEEND = 2,
        OPTION = 3
    }
    //enum : 열거형
    // 숫자 1이 A를 표현할거야. 약속.

    internal static class switch조건문
    {
        static USERINPUT userEnInput;
        public static void Show()
        {
            Console.WriteLine("switch 조건문 강의");

            //if - else if - else if - else if - else if 너무 비효율적이다

            Console.Write("입력을 넣어주세요 (1.게임시작 2.게임종료 3.옵션) : ");
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput) //case를 판별할 변수
            {
                case 1:
                    Console.WriteLine("1.게임 시작");
                    break;
                case 2:
                    Console.WriteLine("2. 게임 종료");
                    break; 
                case 3:
                    Console.WriteLine("3. 옵션");
                    break;
                default:
                    Console.WriteLine("잘못된 입력");
                    break;
            }

            //if (userInput == 1)
            //swhtch문 사용시 주의사항
            //break 안넣으면 다음것까지 실행
        }
    }
}
