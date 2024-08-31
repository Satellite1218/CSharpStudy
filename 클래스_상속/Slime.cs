using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//클래스 상속
//

namespace 클래스_상속
{

    class Monster
    {
        public int HP;
        public int Power;


        //virtual 키워드를 수식받는 함수는 자식에서 같은 이름의 함수를 찾는다
        public virtual void Attack(Player player)
        {
            //몬스터가 플레이어를 공격
            player.HP -= Power;
            //Console.WriteLine("몬스터가 플레이어를 공격");
        }

        public void BeAttack(Player player)
        {
            //플레이어가 몬스터를 공격
            HP -= player.Power;
            //Console.WriteLine("플레이어가 몬스터를 공격");
        }

        public void PowerAttack()
        {
            Slime slime = new Slime();

            if(slime is Slime)
            {
                slime.divide();
            }
        }
    }

    /*
     * 슬라임도 몬스터라 출력
     * wolf도 몬스터라 출력
     * slime은 slime가 공격했다! wolf는 wolf가 공격했다!
     */

    //Slime은 Monster를 상속
    internal class Slime : Monster
    {
        //new키워드를 사용한 트릭
        //부모 함수와는 다른 새로운 함수

       /* public new void Attack(Player player)
        {
            Console.WriteLine("새 공격(슬라임)");
        }
        public void Attack(Player player)
        {
            base.Attack(player);
            Console.WriteLine("슬라임의 공격");
        }*/

        //virtual함수를 수식받는 override
        public override void Attack(Player player)
        {
            base.Attack(player);
            Console.WriteLine("슬라임의 공격");
        }

        public void divide()
        {
            Console.WriteLine("슬라임이 분열되었다");
        }
    }

    class Bear : Monster
    {
        public override void Attack(Player player)
        {
            Console.WriteLine("곰이 공격했다");
        }

        public void Howling()
        {
            Console.WriteLine("곰이 울부짖었다");
        }
    }
}
