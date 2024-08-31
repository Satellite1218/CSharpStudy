using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 클래스_상속
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("클래스 상속");

            Player player = new Player();
            player.HP = 100;
            player.Power = 10;

            Slime slime = new Slime();
            slime.HP = 50;
            slime.Power = 5;

            Bear bear = new Bear();
            bear.HP = 30;
            bear.Power = 3;

            player.Attack(bear);

            slime.Attack(player);

            bear.Attack(player);

            slime.PowerAttack(); //슬라임 분열
            bear.PowerAttack(); //곰이 울부짖음
        }
    }
}