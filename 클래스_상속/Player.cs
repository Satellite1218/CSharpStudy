using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 클래스_상속
{

    /*
     * 플레이어 기능 만들기
     * 1.공격
     * 2.휴식
     * 3.도망
     * 
     */

    internal class Player
    {
        public int HP;
        public int Power;

        public void Attack(Monster monster)
        {
            //플레이어가 슬라임을 공격
            monster.HP -= Power;
            Console.WriteLine("플레이어가 슬라임을 공격");
            Console.WriteLine($"몬스터의 현제체력 : {monster.HP}");
        }

        public void BeAttack(Monster monster)
        {
            //슬라임이 플레이어를 공격
            HP -= monster.Power;
            Console.WriteLine("슬라임이 플레이어를 공격");
            Console.WriteLine($"플레이어의 현재 체력 : {HP}");
        }
    }
}
