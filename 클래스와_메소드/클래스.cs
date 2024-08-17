using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 클래스와_메소드
{
    internal class 클래스
    {
    }

    class slime
    {
        public int HP;
        public int MoveSpeed;
        public string name;

        /*
         * 메소드: 코드를 하나의 이름 아래 묶는것
         * 묶인 코드를 이름을 불러주는 것으로 실행할수 있다
         * 메소드를 호출하는 것을 Call method (메소드 호출)
         */

        /*
         * (접근지정자) (반환값) (메소드의 이름) () { }
         * public      void    Show()    { 묶인 코드 내용 }
         * 
         * 접근지정자: private public => public 선언 해주기
         * 반환값이 없는 경우 : void
         * 반환갑이 있는 경우 : int, float, string, class이름
         * 메소드의 이름 : Show () ; 1.Show(이름) 2.소괄호 ( ) 3. ; => 3개의 기호가 합쳐져서 Show 메소드 안에 있느 코드들을 호출한다
         */

        int ReturnHP()
        {
            //반환갑싱 있는 함수인 경우 return + 변수의 이름 + ; => 해당하는 변수 값을 변환한다.
            return HP;
        }

        int ReturnMoveSpeed()
        {
            return MoveSpeed;
        }

        String ReturnName()
        {
            return name;
        }

        //슬라임이 공격하는 메소드를 만들어보세요
        public void Attack()
        {

        }

        public void Show()
        {

        }
    }
}
