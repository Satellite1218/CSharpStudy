using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 코드_흐름_제어
{
    internal static class while반복문
    {
        public static void Show()
        {
            Console.WriteLine("While반복문");

            int number = 0;

            // while() 조건식이 false가 될 때 까지 반복한다.
            while (number < 10) // 조건식
            {
                Console.WriteLine(number);
                number++;
            }
            //무한반복 실행중 탈출하기 -> break;
            Console.WriteLine();

            // 1~10까지의 짝수만 출력하는 코드
            int num2 = 0;
            while (num2 <= 10)
            {
                if (num2 % 2 == 0)
                {
                    Console.WriteLine(num2);
                }

                num2++;
            }
            Console.WriteLine();

            // 1~10까지의 홀수만 출력하는 코드
            int num3 = 0;
            while (num3 <= 10)
            {
                if (num3 % 2 != 0)
                {
                    Console.WriteLine(num3);
                }

                num3++;
            }
            Console.WriteLine();

            //1부터 100사이의 3의 배수
            int num4 = 0;
            while (num4 <= 100)
            {
                if (num4 % 3 == 0)
                {
                    Console.WriteLine(num4);
                }

                num4++;
            }
            Console.WriteLine();
        }
    }
}
