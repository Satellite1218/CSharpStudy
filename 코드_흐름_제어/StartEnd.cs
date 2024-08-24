using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mob;
using 코드_흐름_제어;

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

    class Boss
    {
        public string name = "Boss Monster";
        public int attck = 30;
        public int hp = 150;
        public int xp = 500;
        public int speed = 50;

        public void BossShow()
        {
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"공격력: {attck}");
            Console.WriteLine($"HP: {hp}");
            Console.WriteLine($"이동속도: {speed}");
            Console.WriteLine($"경험치: {xp}\n");
        }
    }
}

namespace 코드_흐름_제어
{
    internal class StartEnd
    {
        public void Start()
        {
            Console.WriteLine("게임이 시작되었습니다.");

            Game game = new Game();
            game.run();
        }

        public void Option()
        {
            int Commed;
            bool Exit;
            do
            {
                Console.WriteLine("=======옵션 메뉴=======");
                Console.WriteLine("1. 화면 설정  2. 조작키 설정");
                Console.WriteLine("3. 게임 설정  4. 돌아가기");

                Console.Write("입력을 기다리고 있습니다 : ");
                Commed = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (Commed)
                {
                    case 1:
                        Console.WriteLine("1.화면설정\n");
                        Exit = false;
                        break;
                    case 2:
                        Console.WriteLine("2.조작키설정\n");
                        Exit = false;
                        break;
                    case 3:
                        Console.WriteLine("3.게임설정\n");
                        Exit = false;
                        break;
                    case 4:
                        Exit = true;
                        break;
                    default:
                        Console.WriteLine("잘못된 입력값 입니다. 다시 입력해 주세요.\n");
                        Exit = false;
                        break;
                }
            } while (Exit == false);
            Console.Clear();
        }

        public void Game()
        {
            int userInput;
            bool Input;
            do
            {
                Console.WriteLine("=======게임 메뉴 출력=======");
                Console.WriteLine("1. 게임 시작");
                Console.WriteLine("2. 게임 종료");
                Console.WriteLine("3. 옵션");

                Console.Write("입력을 기다리고 있습니다 : ");
                userInput = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (userInput)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\n게임 시작");
                        Start();
                        Input = false;
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("\n게임 종료");
                        Input = true;
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("\n옵션");
                        Option();
                        Input = false;
                        break;

                    default:
                        Console.WriteLine("\n잘못된 입력값 입니다. 다시 입력해 주세요.");
                        Input = false;
                        break;
                }
            } while (Input == false);
            Console.Clear();

        }
    }
}

internal class Game
{
    mob.player player = new mob.player();
    mob.슬라임 slime = new mob.슬라임();

    public void PlayerTurn(player player, 슬라임 slime)
    {
        StartEnd start = new StartEnd();

        Console.WriteLine("1. 공격한다");
        Console.WriteLine("2. 강화 공격을 한다(MP소모)");
        Console.WriteLine("3. 휴식한다");
        Console.WriteLine("4. 스탯 보기(턴 소모X)");
        Console.WriteLine("5. 메인 화면 으로 돌아가기");
        Console.WriteLine("유저의 행동을 입력해 주세요");
        int userInput = int.Parse(Console.ReadLine());
        Console.Clear();
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
        else if (userInput == 4)
        {
            Console.Clear();
            player.PlayerShow();
            slime.SlimeShow();
        }
        else if (userInput == 5)
        {
            Console.Clear();
            Console.WriteLine("메인 화면으로 돌아갑니다.");
            start.Game();
        }
        else
        {
            Console.WriteLine("잘못된 입력값 입니다. 다시 입력해 주세요.\n");
        }
    }

    public void Attack()
    {
        Console.Clear();
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
        Console.Clear();
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

    public void Attacked()
    {
        Console.WriteLine($"{slime.name}의 공격! (플레이어 hp {player.hp} -> {player.hp - slime.attck})");
        player.hp -= slime.attck;
        if (player.hp <= 0)
        {
            death();
        }
        Console.WriteLine("========결과========");
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
