using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 코드_흐름_제어
{
    //static 키워드를 선언하면
    //클래스의 인스턴스가 아니라 객체 그 자체에 접근하게 된다 (그냥 클래스 선언 없이 호출 가능한거)
    //if조건문.show();
    static class if조건문
    {
        public static void Show() // 강의 내용을 출력하는 메소드
        {
            Console.WriteLine("if조건문");

            //1. 위에서 부터 순서대로 실행되는 구조가 아닌 선택으로 실행되는 코드의 흐름제어
            //1-1. 조건식 : 조건문을 실행할지 말지 경정하는 문

            //true, false 조건문에 직접 할당
            if(true)
            {
                Console.WriteLine("if문이 실행 됨");
            }

            Console.WriteLine("아무 수나 입력하세요");
            int num = int.Parse(Console.ReadLine());

            if(num >= 5) Console.WriteLine("num이 5보다 크다");
            else if(num <= 0) Console.WriteLine("num이 5보다 작다");

            //2. if조건문 사용시 주의해야할 사항

            Console.Write("숫자를 입력해 주세요 : ");
            int num2 = int.Parse(Console.ReadLine());
            if (num2 >= 5)
            {
                Console.WriteLine("num가 5보다 크다");
            }

            //3. 조건문 사용시 혼돈이 가는 부분
            if (num2 > 5)
                Console.WriteLine("조건문이 한줄인 경우에는 중괄호 없이 표현 가능하다");
            else Console.WriteLine("num가 5보다 작거나 같다");

            //4.중괄호 없이 if문을 사용할때 주의해야할 사항

            if(num2 > 5)
                Console.WriteLine("num2가 5보다 크다"); // 조건문 영향 받음
                Console.WriteLine("이건 그냥 출력"); // 조건문 영향 안받음

            //5.조건이 여러개일 경우
            // else if
            // 여러개면 switch case가..

            Console.Write("입력을 넣어주세요 (1.게임시작 2.게임종료 3.옵션) : ");
            int userinput = int.Parse(Console.ReadLine()); //1. 게임 시작 2. 게임 종료 3.옵션

            if (userinput == 1)
            {
                Console.WriteLine("게임 시작");
            }
            else if (userinput == 2)
            {
                Console.WriteLine("게임 종료");
            }
            else if(userinput == 3)
            {
                Console.WriteLine("옵션");
            }
            else
            {
                Console.WriteLine("잘못된 입력값 입니다. 다시 입력해 주세요.");
            }
        }
    }
}
