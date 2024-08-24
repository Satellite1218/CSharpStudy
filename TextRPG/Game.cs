using mob;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.XPath;
using TextRPG;

namespace mob
{

    class player
    {

        public string name = "플레이어";
        public int attck = 10;
        public int hp = 50;
        public int mp = 50;
        public int xp = 0;
        public int xpmax = 100;
        public int speed = 50;
        public int level = 1;

        public void PlayerShow()
        {
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"공격력: {attck}");
            Console.WriteLine($"HP: {hp}");
            Console.WriteLine($"MP: {mp}");
            Console.WriteLine($"이동속도: {speed}");
            Console.WriteLine($"레벨: {level}\n");
        }

    }

    class 슬라임
    {
        public string name = "슬라임";
        public int attck = 15;
        public int hp = 80;
        public int xp = 100;
        public int speed = 20;

        public void SlimeShow()
        {
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"공격력: {attck}");
            Console.WriteLine($"HP: {hp}");
            Console.WriteLine($"이동속도: {speed}");
            Console.WriteLine($"경험치: {xp}\n");
        }
    }
}

namespace TextRPG
{
    internal class Game
    {
        mob.player player = new mob.player();
        mob.슬라임 slime = new mob.슬라임();
        
        void PlayerTurn(player player, 슬라임 slime)
        {
            Console.WriteLine("1. 공격한다");
            Console.WriteLine("2. 강화공격을 한다(MP소모)");
            Console.WriteLine("3. 휴식한다");
            Console.WriteLine("4. 도망친다");
            Console.WriteLine("5. 스탯보기(턴 소모X)");
            Console.WriteLine("유저의 행동을 입력해 주세요");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                Attack();
            }
            else if (userInput == 2)
            {
                PowerAttack();
            }
            else if (userInput == 3)
            {
                rest();
            }
            else if(userInput == 4)
            {
                running();
                run();
            }
            else if (userInput == 5)
            {
                player.PlayerShow();
                slime.SlimeShow();
            }
        }

        public void Attack()
        {
            Console.WriteLine($"\n{player.name}의 공격! (적 hp {slime.hp} -> {slime.hp - player.attck})");
            slime.hp -= player.attck;
            if (slime.hp <= 0)
            {
                kill();
            }
            Attacked();
        }
        public void PowerAttack()
        {
            Console.WriteLine($"\n{player.name}의 강화공격! (적 hp {slime.hp} -> {slime.hp - player.attck * 2})");
            slime.hp -= player.attck * 2;
            if (slime.hp <= 0)
            {
                kill();
            }
            Attacked();
        }
        public void rest()
        {
            Console.WriteLine("잠깐 쉬었습니다 (HP 20, MP 15 회복)\n");
            player.hp += 20;
            player.mp += 15;
            Attacked();
        }

        public void running()
        {
            if (player.speed > slime.speed)
            {
                Console.WriteLine("무사히 도망쳤습니다");
            }
            else
            {
                Console.WriteLine($"맞으며 도망쳤습니다(HP - {slime.attck})");
                player.hp -= slime.attck;
                if(player.hp <= 0)
                {
                    death();
                }
            }
        }

        public void Attacked()
        {
            Console.WriteLine($"{slime.name}의 공격! (플레이어 hp {player.hp} -> {player.hp - slime.attck})");
            player.hp -= slime.attck;
            if(player.hp <= 0)
            {
                death();
            }
            Console.WriteLine("---------결과---------");
            player.PlayerShow();
            slime.SlimeShow();
        }

        public void kill()
        {
            Console.WriteLine($"{slime.name}은 쓰러졌다! (경험치{slime.xp})");
            player.xp += slime.xp;
            if (player.xp >= player.xpmax)
            {
                Console.WriteLine($"레벨 업!({player.level} -> {player.level + 1})");
                player.xp -= player.xpmax;
                player.xpmax += 20;
                run();
            }
        }

        public void death()
        {
            Console.WriteLine("게임오버 되었습니다.");
        }

        public void run()
        {
            // 정답에 해당하는 숫자 랜덤으로 받아오기
            Random rand = new Random();
            int scr = rand.Next(1, 3);

            slime.hp = 30;
            Console.WriteLine($"\n{slime.name}을(를) 발견했다!\n");
            slime.SlimeShow();
            while (true)
            {
                PlayerTurn(player, slime);
            }
        }
    }
}
