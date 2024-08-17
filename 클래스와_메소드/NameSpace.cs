/*
 * 학습목표 : 이름공간 : 네임스페이스에 대한 이해
 * 작성일: 24.8.17
 * 작성자: 이신우
 */

/*
 * 이름 : 다른 이름을 가짐으로서 구분할수 있다.
 * 만약 같은 이름이 중복되면 어떻게 될까?
 * -> 컴파일에러 발생
 * 
 * 다른 비교사항이 있다면 두 대상을 구분 가능
 * 네임스페이스: 같은 이름을 분류하는 이름 공간
 */

/*
 * 2. 네임스페이스 선언방법
 * namespace 이름공간의 이름 {  }  범위를 표현해주는 기호
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 부산
{
    class 냉면
    {
        public int count;
    }
}
namespace 서울
{
    class 냉면
    {
        public int count;
    }
}

namespace 컴포즈
{
    class 커피
    {
        public string name;
    }
}
namespace 메가
{
    class 커피
    {
        public string name;
    }
}

namespace 클래스와_메소드
{
    internal class NameSpace
    {
        public void Show()
        {
            Console.WriteLine("Hello World!\n");

            //같은 이름이 중복되면 안되는 예시
            int num = 10;
            int num2 = 20;

            부산.냉면 noodle = new 부산.냉면();
            noodle.count = 1;
            Console.WriteLine(noodle.count);
            서울.냉면 noodle2 = new 서울.냉면();
            noodle2.count = 10;
            Console.WriteLine(noodle2.count + "\n");

            컴포즈.커피 coffee = new 컴포즈.커피();
            coffee.name = "컴포즈커피";
            Console.WriteLine(coffee.name);
            메가.커피 coffee2 = new 메가.커피();
            coffee2.name = "메가커피";
            Console.WriteLine(coffee2.name);
        }
    }
}
