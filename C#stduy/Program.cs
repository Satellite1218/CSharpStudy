// 주석: 배열은 /**/ 파이썬은 #
/*
C# 언어로 프로그래밍 시작하기, 변수 이해
*/
/*
프로그래밍 + 언어
프로그래밍 : 컴퓨터로 프로그램을 실행시키는 작업
언어: 두 객체 사이의 의사소통을 위한 도구
프로그래밍 언어: 컨퓨터와 사람이 대화를 하기 위해 필요한 언어

사람은 기계가 하는 말을 알아들을수 없음
기계는 사람말을 알아먹을수 없음
번역기, 통역사 == 컴파일러
C, C++ C#, Python, Java, JS, Ruby, Purl, php, TS -> 번역이 다름
*/
/*
 * 컴퓨터는 사람이 사용하는 언어를 표현하는 방식으로 표현하려면
 * 키워드: 이미 의미가 정해져있는 단어 파란색으로 표현
 * 흰색: 어떳것(데이터타입)의 이름
 * 밖은노랑: 함수
 * 정수는 int로 표현
 * 실수는 float로 표현
 * 문자는 char으로 표현 문자열은 string
 */
using System;

namespace CSharpStudy
{
    internal class NumCount
    {
        string talk;
        int n;

        // 정답을 맞출 수 있는 횟수       
        int shild = 5;

        public void Play(int rand)
        {
            while (shild > 0)
            {
                Console.Write($"숫자를 적으시오 (1 ~ 20) (남은 횟수 {shild}회) : ");
                talk = Console.ReadLine();
                n = int.Parse(talk);

                // 숫자를 맞추면 게임종료
                if (n == rand)
                {
                    Console.WriteLine("정답\n");
                    break;
                }

                // 숫자를 맞추지 못하면 다시 맞추는 기능
                else
                {
                    if (shild - 1 == 0)
                    {
                        Console.WriteLine("실패\n");
                    }
                    else if (n < rand)
                    {
                        Console.WriteLine("UP");
                    }
                    else if (n > rand)
                    {
                        Console.WriteLine("DOWN");
                    }
                    shild--;
                }
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // 정답에 해당하는 숫자 랜덤으로 받아오기
            Random rand = new Random();
            int scr = rand.Next(1, 21);

            NumCount game = new NumCount();
            Console.Write("숫자 게임을 플레이하시려면 1, 아니면 아무키나 눌러주세요 : ");
            string ch = Console.ReadLine();
            if (ch == "1")
            {
                game.Play(scr);
            }

            Console.WriteLine("정수, 실수, 문자, 문자열 입력");
            //변수: 변하는 수, 출력시 값이 변할수 있는 형태
            //변수 선언
            // 키워드의 이름;
            //키워드: int(띄워쓰기)
            //이름 : number
            int number = 10;

            int num = 100;
            Console.WriteLine(number);
            Console.WriteLine(num + "\n");

            int num2 = 20, num3 = 10;
            Console.WriteLine(num2 + num3);
            Console.WriteLine(num2 - num3);
            Console.WriteLine(num2 * num3);
            Console.WriteLine(num2 / num3);
            Console.WriteLine(num2 % num3 + "\n");

            // 키워드 : float
            //변수 선언
            //변수 초기화
            //변수 사칙연산
            float f1 = 5.5f, f2 = 2.2f;
            Console.WriteLine(f1 - f2);
            Console.WriteLine(f1 * f2);
            Console.WriteLine(f1 / f2);
            Console.WriteLine(f1 % f2 + "\n");

            // 키워드 : char
            //변수 선언
            //변수 초기화
            //변수 사칙연산
            char c1 = 'a', c2 = 'b';
            Console.WriteLine(c1 + " " + c2 + "\n");

            // 키워드 : string
            //변수 선언
            //변수 초기화
            //변수 사칙연산
            string s1 = "hello", s2 = "world";
            Console.WriteLine(s1 + " " + s2);

            int width = 10, height = 10;
            Console.WriteLine($"사각형의 넓이 : {width * height}");

            //원의넓이
            //반지름 * 반지름 * 3.14
            Console.Write("원의 넓이를 구할 원의 반지름을 적으시오 :");
            string t = Console.ReadLine();
            int s = int.Parse(t);
            Console.WriteLine($"원의 넓이 : {s * s * 3.14}");

        }
    }
}