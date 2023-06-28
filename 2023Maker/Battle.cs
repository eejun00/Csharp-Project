using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2023Maker
{
    public class Battle
    {
        ConsoleScreen screen;
        public void BattleStart(ref int playerHp)
        {
            Random random = new Random();
            
            int slimeHp = 30;       //몬스터들의 체력과 공격력
            int slimeAttack = 3;
            int wolfHp = 40;
            int wolfAttack = 5;
            int undeadHp = 50;
            int undeadAttack = 4;



            int playerAttack = 10;
            int mobdice = random.Next(1, 4); // 몬스터 만날 확률 주사위

            for (int i = 0; i< 30; i++)
            {
                Console.SetCursorPosition(4, i+6);
                Console.WriteLine("                                                                              ");
                Thread.Sleep(20);
            }

            for (int i = 0; i< 10; i++)
            {
                Console.SetCursorPosition(4, i+37);
                Console.WriteLine("                                                                             ");
            }
            Console.SetCursorPosition(5, 38);
            switch (mobdice) //몬스터 종류 정하는 스위치문
            {
                case 1:
                    Console.WriteLine("슬라임을 조우했다.\n");
                    Thread.Sleep(500);
                    monsterbattle(slimeHp, slimeAttack, playerAttack, ref playerHp);
                    Console.ReadKey(true);
                    break;
                case 2:
                    Console.WriteLine("늑대를 조우했다.\n ");
                    Thread.Sleep(500);
                    monsterbattle(wolfHp, wolfAttack, playerAttack, ref playerHp);
                    Console.ReadKey(true);
                    break;
                default:
                    Console.WriteLine("언데드를 조우했다.\n ");
                    Thread.Sleep(500);
                    monsterbattle(undeadHp, undeadAttack, playerAttack, ref playerHp);
                    Console.ReadKey(true);
                    break;

            }

        }




        public void monsterbattle(int monsterHp, int monsterAttack, int playerAttack, ref int playerHp) //몬스터와의 배틀 계산 함수
        {
            screen = new ConsoleScreen();
            while (monsterHp > 0 && playerHp > 0)
            {
                Console.SetCursorPosition(6, 40);
                Console.Write("적의 체력 : {0} 적의 공격력 : {1}", monsterHp, monsterAttack);
                Console.SetCursorPosition(6, 42);
                Console.Write("나의 체력 : {0} 나의 공격력 {1}\n", playerHp, playerAttack);
                Thread.Sleep(700);
                Console.WriteLine();
                Console.SetCursorPosition(40, 40);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("적을 공격합니다! 데미지 {0}!\n ", playerAttack);
                monsterHp -= playerAttack;
                Thread.Sleep(300);
                Console.SetCursorPosition(40, 42);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("적이 나를 공격합니다! 데미지 {0}!\n", monsterAttack);
                playerHp -= monsterAttack;
                Console.WriteLine();
                Thread.Sleep(500);
                Console.ResetColor();
                screen.ClearUnder();
            }
            if (playerHp <= 0)
            {
                Console.SetCursorPosition(6, 40);
                Console.Write("적과의 전투에서 패배했습니다.. 다음에 다시 도전해보세요..\n\n");
                return;
            }
            Console.SetCursorPosition(6, 40);
            //Console.Write("적의 체력 : {0} 적의 공격력 : {1}        나의 체력 : {2} 나의 공격력 {3}\n", monsterHp, monsterAttack, playerHp, playerAttack);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(28, 41);
            Console.Write("적과의 전투에서 승리했습니다!\n\n");
            Thread.Sleep(500);
            Console.ResetColor();            

        }

    }
}
