using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 코드_흐름_제어
{
    internal static class for반복문
    {
        public static void Show()
        {
            Console.WriteLine("For반복문");

            //1.반복문을 왜 사용하는가

            Console.Write("최종 출력할 값을 적으시오 : ");
            int userInput = int.Parse(Console.ReadLine());

            for (int i = 1; i <= userInput; i++)
            {
                Console.WriteLine(i);
            }

            //2. for문을 언제 사용하는가
            //반복할 횟수가 정해져있는 경우 -> for
            //반복할 횟수가 정해져 있고 특정 case에 종료되는 경우 -> while

            //3. for문의 조건식이 항상 참이면 어떻게 되는가

            int num = 0;

            for (; ; ) //for 무한 반복문
            {
                Console.WriteLine(num++);
                //탈출 가능한 조건을 추가
                if (num == 10)
                {
                    Console.WriteLine("탈출조건을 만족해 탈출합니다.");
                    break;
                }
            }
        }
    }
}
