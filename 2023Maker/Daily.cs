using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Collections;

namespace _2023Maker
{
    public class Daily
    {

        Script script = new Script();
        ConsoleScreen screen = new ConsoleScreen();
        Art art = new Art();

        public List<string> place = new List<string>() { "체육관", "음식점", "옷가게", "서점" };
        public List<string> subjects = new List<string>() { "체육", "미술", "학문", "예법" };


        public string optionOne = "1.외출하기";
        public string optionTwo = "2.휴식하기";
        public string optionThree = "3.대화나누기";
        public string optionFour = "4.조언듣기";


        //하루 일과 진행옵션의 세부
        public string firstOption = "1.단련하기";
        public string secondOption = "2.번화가 놀러가기";
        public string thirdOption = "3.학교에 가기";
        public string fourthOption = "4.봉사활동 가기";


        //체력 상승이 주가 되는 첫번째 선택지 진행 내용
        public void FirstDailyOption<T>(ref T state) where T : State
        {
            Map map1 = new Map();
            Battle battle1 = new Battle();
            Random random = new Random();

            const int MAP_SIZE_X = 26;
            const int MAP_SIZE_Y = 15;
            const char PLAYER = '◎';
            int playerHp = 100;
            int y_axis = 5;
            int x_axis = 5;
            int surprise = default;
            int monsterCount = default;
            bool exit = true;

            screen.ClearScreen();
            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.training[0]);
            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.training[1]);
            screen.ClickNext();
            screen.ClearUnder();
            map1.CreateMap();
            map1.PrintMap();

           
            while (monsterCount < 3 && exit)
            {
                
                Console.CursorVisible = false;
                ConsoleKeyInfo keyInput = Console.ReadKey(true); //키입력을 받고 확인하는 내용

                switch (keyInput.Key)
                {

                    case ConsoleKey.LeftArrow:
                        if (x_axis <= 1)
                        {
                            /*Pass*/
                        }
                        else
                        {
                            if (x_axis > 1) // 이동 가능할 경우
                            {

                                if (map1.map[y_axis, (x_axis-1)] == '▲') // 산에 도착할 경우
                                {
                                    if ((x_axis > 14 && x_axis< 28) && (y_axis >1 && y_axis < 6))
                                    {
                                        map1.map[y_axis, x_axis] = '▲';
                                        map1.map[y_axis, --x_axis] = PLAYER;
                                    }
                                    else
                                    {
                                        map1.map[y_axis, x_axis] = 'ㅤ';
                                        map1.map[y_axis, --x_axis] = PLAYER;
                                    }
                                    surprise = random.Next(1, 101);
                                    if (surprise <= 14)
                                    {
                                        battle1.BattleStart(ref playerHp);
                                        monsterCount++;
                                        screen.ClearScreen();
                                    }

                                }

                                else //그냥 이동시
                                {
                                    if ((x_axis > 14 && x_axis< 28) && (y_axis >1 && y_axis < 6))
                                    {
                                        map1.map[y_axis, x_axis] = '▲';
                                        map1.map[y_axis, --x_axis] = PLAYER;
                                    }
                                    else
                                    {
                                        map1.map[y_axis, x_axis] = 'ㅤ';
                                        map1.map[y_axis, --x_axis] = PLAYER;
                                    }
                                }
                            }


                        }
                        break;

                    case ConsoleKey.RightArrow:
                        if (x_axis < (MAP_SIZE_X-2)) // 이동 가능한 경우
                        {


                            if (map1.map[y_axis, (x_axis+1)] == '▲') // 산에 도착할 경우
                            {
                                if ((x_axis > 14 && x_axis< 28) && (y_axis >1 && y_axis < 6))
                                {
                                    map1.map[y_axis, x_axis] = '▲';
                                    map1.map[y_axis, ++x_axis] = PLAYER;
                                }
                                else
                                {
                                    map1.map[y_axis, x_axis] = 'ㅤ';
                                    map1.map[y_axis, ++x_axis] = PLAYER;
                                }
                                surprise = random.Next(1, 101);
                                if (surprise <= 14)
                                {
                                    battle1.BattleStart(ref playerHp);
                                    monsterCount++;
                                    screen.ClearScreen();
                                }

                            }
                            else
                            {
                                if ((x_axis > 14 && x_axis< 28) && (y_axis >1 && y_axis < 6))
                                {
                                    map1.map[y_axis, x_axis] = '▲';
                                    map1.map[y_axis, ++x_axis] = PLAYER;
                                }
                                else
                                {
                                    map1.map[y_axis, x_axis] = 'ㅤ';
                                    map1.map[y_axis, ++x_axis] = PLAYER;
                                }
                            }
                        }
                        else
                        {
                            /*Pass*/
                        }
                        break;

                    case ConsoleKey.UpArrow:
                        if (y_axis <= 1)
                        {
                            /*Pass*/
                        }

                        else
                        {
                            if (map1.map[(y_axis-1), x_axis] == '▲')
                            {
                                surprise = random.Next(1, 101);
                                if ((x_axis > 14 && x_axis< 28) && (y_axis >1 && y_axis < 6))
                                {
                                    map1.map[y_axis, x_axis] = '▲';
                                    map1.map[--y_axis, x_axis] = PLAYER;
                                }
                                else
                                {
                                    map1.map[y_axis, x_axis] = 'ㅤ';
                                    map1.map[--y_axis, x_axis] = PLAYER;
                                }
                                if (surprise <= 14)
                                {
                                    battle1.BattleStart(ref playerHp);
                                        monsterCount++;
                                    screen.ClearScreen();
                                }

                            }
                            else
                            {
                                if ((x_axis > 14 && x_axis< 28) && (y_axis >1 && y_axis < 6))
                                {
                                    map1.map[y_axis, x_axis] = '▲';
                                    map1.map[--y_axis, x_axis] = PLAYER;
                                }
                                else
                                {
                                    map1.map[y_axis, x_axis] = 'ㅤ';
                                    map1.map[--y_axis, x_axis] = PLAYER;
                                }
                            }
                        }

                        break;

                    case ConsoleKey.DownArrow:
                        if (y_axis < (MAP_SIZE_Y-2))
                        {


                            if (map1.map[(y_axis+1), x_axis] == '▲')
                            {
                                surprise = random.Next(1, 101);
                                if ((x_axis > 14 && x_axis< 28) && (y_axis >1 && y_axis < 6))
                                {
                                    map1.map[y_axis, x_axis] = '▲';
                                    map1.map[++y_axis, x_axis] = PLAYER;
                                }
                                else
                                {
                                    map1.map[y_axis, x_axis] = 'ㅤ';
                                    map1.map[++y_axis, x_axis] = PLAYER;
                                }
                                if (surprise <= 14)
                                {
                                    battle1.BattleStart(ref playerHp);
                                        monsterCount++;
                                    screen.ClearScreen();
                                }

                            }
                            else
                            {
                                if ((x_axis > 14 && x_axis< 28) && (y_axis >1 && y_axis < 6))
                                {
                                    map1.map[y_axis, x_axis] = '▲';
                                    map1.map[++y_axis, x_axis] = PLAYER;
                                }
                                else
                                {
                                    map1.map[y_axis, x_axis] = 'ㅤ';
                                    map1.map[++y_axis, x_axis] = PLAYER;
                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine("\n벽에 막혀 더이상 갈 수 없습니다.");
                        }
                        break;
                    //case ConsoleKey.I:
                    //    shop1.Printinven(inventory);
                    //    Thread.Sleep(2000);
                    //    Console.Clear();
                    //    break;
                    case ConsoleKey.Q:
                        string question = "단련을 중단하고 집으로 돌아가시겠습니까? (돌아가려면 Y)";
                        Console.SetCursorPosition(15, 41);
                        script.PrintOneAtTime(question);
                        ConsoleKeyInfo ans = Console.ReadKey(true);
                        switch(ans.Key)
                        {
                            case ConsoleKey.Y:
                                exit = false;
                                break;
                            default:
                                break;
                        }
                        break;
                        
                    default:
                        //Console.WriteLine("\n\n입력이 잘못되었습니다.\n");
                        break;
                }
                map1.PrintMap();
            }
            screen.ClearScreen();
            Console.SetCursorPosition(5, 38);
            if (monsterCount == 3)
            {                
                Console.Write("단련을 마치고 체력이 {0} 올랐습니다!!", 40);
                state.strength += 40;
            }
            else
            {
                Console.Write("단련을 마치고 체력이 {0} 올랐습니다!!", monsterCount*10);
                state.strength += 10*monsterCount;
            }           
            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.training[2]);
            screen.ClickNext();
            
        }

        //매력 상승이 주가 되는 두번째 선택지 진행 내용
        public void SecondDailyOption<T>(ref T state) where T : State
        {
            Random random = new Random();
            int stat1 = 10;
            int stat2 = 20;
            int todayPlace = default;
            todayPlace = random.Next(0, place.Count);

            screen.ClearUnder();
            Console.SetCursorPosition(5, 38);

            for (int i = 0; i < script.downtown[0].Length; i++)
            {
                Console.Write(script.downtown[0][i]);
                Thread.Sleep(50);
            }

            Console.SetCursorPosition(5, 41);

            for (int i = 0; i < script.downtown[1].Length; i++)
            {
                Console.Write(script.downtown[1][i]);
                Thread.Sleep(50);
            }
            Console.Write("* {0} *입니다.", place[todayPlace]);

            Thread.Sleep(300);
            screen.ClearOver();
            art.PrintJumpRabbit();
            screen.ClickNext();
            screen.ClearUnder();;

            switch (todayPlace)
            {
                case 0: //체육관
                    Console.SetCursorPosition(5, 38);

                    for (int i = 0; i < script.gym[0].Length; i++)
                    {
                        Console.Write(script.gym[0][i]);
                        Thread.Sleep(50);
                    }

                    Console.SetCursorPosition(5, 41);

                    for (int i = 0; i < script.gym[1].Length; i++)
                    {
                        if (script.gym[1][i] == '.')
                        {
                            Console.Write(script.gym[1][i]);
                            Thread.Sleep(800);
                        }
                        else
                        {
                            Console.Write(script.gym[1][i]);
                            Thread.Sleep(50);
                        }
                    }
                    state.strength += stat1;
                    state.charm += stat2;

                    screen.ClearUnder();
                    Console.SetCursorPosition(5, 38);
                    Console.Write("보람찬 하루를 보내고 체력이 {0}, 매력이 {1} 올랐습니다!!", stat1, stat2);
                    break;
                case 1: //음식점
                    Console.SetCursorPosition(5, 38);

                    for (int i = 0; i < script.restaurant[0].Length; i++)
                    {
                        Console.Write(script.restaurant[0][i]);
                        Thread.Sleep(50);
                    }

                    Console.SetCursorPosition(5, 41);

                    for (int i = 0; i < script.restaurant[1].Length; i++)
                    {
                        if (script.restaurant[1][i] == '.')
                        {
                            Console.Write(script.restaurant[1][i]);
                            Thread.Sleep(800);
                        }
                        else
                        {
                            Console.Write(script.restaurant[1][i]);
                            Thread.Sleep(50);
                        }
                    }
                    state.stress -= 20;
                    state.charm += stat2+10;
                    screen.ClearUnder();
                    Console.SetCursorPosition(5, 38);
                    Console.Write("맛있는 하루를 보내고 스트레스를 받지 않고, 매력이 {0} 올랐습니다!!", stat2+10);
                    break;
                case 2: //옷가게
                    Console.SetCursorPosition(5, 38);

                    for (int i = 0; i < script.shopping[0].Length; i++)
                    {
                        Console.Write(script.shopping[0][i]);
                        Thread.Sleep(50);
                    }

                    Console.SetCursorPosition(5, 41);

                    for (int i = 0; i < script.shopping[1].Length; i++)
                    {
                        if (script.shopping[1][i] == '.')
                        {
                            Console.Write(script.shopping[1][i]);
                            Thread.Sleep(800);
                        }
                        else
                        {
                            Console.Write(script.shopping[1][i]);
                            Thread.Sleep(50);
                        }
                    }
                    state.charm += stat2+20;
                    screen.ClearUnder();
                    Console.SetCursorPosition(5, 38);
                    Console.Write("멋있는 하루를 보내고 매력이 무려 {0} 올랐습니다!!", stat2+20);
                    break;
                case 3: //서점
                    Console.SetCursorPosition(5, 38);

                    for (int i = 0; i < script.bookStore[0].Length; i++)
                    {
                        Console.Write(script.bookStore[0][i]);
                        Thread.Sleep(50);
                    }

                    Console.SetCursorPosition(5, 41);

                    for (int i = 0; i < script.bookStore[1].Length; i++)
                    {
                        if (script.bookStore[1][i] == '.')
                        {
                            Console.Write(script.bookStore[1][i]);
                            Thread.Sleep(800);
                        }
                        else
                        {
                            Console.Write(script.bookStore[1][i]);
                            Thread.Sleep(50);
                        }
                    }
                    state.intelligence += stat1;
                    state.charm += stat2;
                    screen.ClearUnder();
                    Console.SetCursorPosition(5, 38);
                    Console.Write("똑똑한 하루를 보내고 지능이 {0}, 매력이 {1} 올랐습니다!!", stat1,stat2);
                    break;
                default:
                    break;
            }
            Thread.Sleep(800);
            Console.SetCursorPosition(5, 41);

            for (int i = 0; i < script.downtown[2].Length; i++)
            {
                Console.Write(script.downtown[2][i]);
                Thread.Sleep(50);
            }
            state.stress += 20;
            state.downtownCount++;
            screen.ClickNext();
        }

        //지성 상승이 주가 되는 세번째 선택지 진행 내용
        public void ThirdDailyOption<T>(ref T state) where T : State
        {
            Random random = new Random();
            int subNum = default;
            int stat1 = 10;
            int stat2 = 20;
            screen.ClearUnder();
            Console.SetCursorPosition(5, 38);

            subNum = random.Next(0, subjects.Count);


            for (int i = 0; i < script.school[0].Length; i++)
            {
                Console.Write(script.school[0][i]);
                Thread.Sleep(50);
            }

            Console.SetCursorPosition(5, 41);

            for (int i = 0; i < script.school[1].Length; i++)
            {
                Console.Write(script.school[1][i]);
                Thread.Sleep(50);
            }
            Console.Write("* {0} *입니다.", subjects[subNum]);


            screen.ClickNext();
            screen.ClearScreen();
            art.PrintStudyRabbit();
            art.PrintAIng();


            Console.SetCursorPosition(28, 41);
            for (int i = 0; i < script.school[2].Length; i++)
            {
                if (script.school[2][i] == '.')
                {
                    Console.Write(script.school[2][i]);
                    Thread.Sleep(800);
                }
                else
                {
                    Console.Write(script.school[2][i]);
                    Thread.Sleep(50);
                }
            }

            Thread.Sleep(500);
            screen.ClearUnder();

            Console.SetCursorPosition(5, 38);
            if (subNum == 0) //체육
            {
                state.strength += 10;
                state.intelligence += 20;
                Console.Write("체육을 열심히 배워서 체력이 {0}, 지능이 {1} 올랐습니다!!", stat1, stat2);
            }
            else if (subNum == 1) //미술
            {
                state.charm += 10;
                state.intelligence += 20;
                Console.Write("미술을 열심히 배워서 체력이 {0}, 지능이 {1} 올랐습니다!!", stat1, stat2);

            }
            else if (subNum == 2) //학문
            {
                state.intelligence += 40;
                Console.Write("학문을 열심히 배워서 지능이 {0} 올랐습니다!!", stat2*2);

            }
            else // 예법
            {
                state.morality += 10;
                state.intelligence += 20;
                Console.Write("예법을 열심히 배워서 체력이 {0}, 지능이 {1} 올랐습니다!!", stat1, stat2);

            }

            Thread.Sleep(800);
            Console.SetCursorPosition(5, 41);

            for (int i = 0; i < script.school[3].Length; i++)
            {
                Console.Write(script.school[3][i]);
                Thread.Sleep(50);
                if (script.school[3][i] == '.')
                {
                    Thread.Sleep(500);
                }
            }

            screen.ClickNext();
            state.stress += 20;
            state.schoolCount += 1;
        }

        //도덕성 상승이 주가 되는 네번째 선택지 진행 내용
        public void FourthDailyOption<T>(ref T state) where T : State
        {
            Random random = new Random();
            int dice = random.Next(1, 3);
            string script1 = "봉사활동을 무난하게 끝마쳐 도덕성이 30 올랐습니다!";
            string script2 = "봉사활동에 열심히 참여하여 도덕성이 무려 40 올랐습니다!";

            screen.ClearUnder();
            Console.SetCursorPosition(5, 38);

            for (int i = 0; i < script.volunteer[0].Length; i++)
            {
                Console.Write(script.volunteer[0][i]);
                Thread.Sleep(50);
            }

            Console.SetCursorPosition(5, 41);

            for (int i = 0; i < script.volunteer[1].Length; i++)
            {
                Console.Write(script.volunteer[1][i]);
                Thread.Sleep(50);
            }

            screen.ClickNext();
            screen.ClearScreen();
            art.PrintVolunteer();

            Console.SetCursorPosition(28, 41);
            for (int i = 0; i < script.volunteer[2].Length; i++)
            {
                if (script.volunteer[2][i] == '.')
                {
                    Console.Write(script.volunteer[2][i]);
                    Thread.Sleep(800);
                }
                else
                {
                    Console.Write(script.volunteer[2][i]);
                    Thread.Sleep(50);
                }
            }

            Thread.Sleep(500);
            screen.ClearUnder();

            Console.SetCursorPosition(5, 38);
            if (dice < 2)
            {
                for (int i = 0; i < script1.Length; i++)
                {
                    Console.Write(script1[i]);
                    Thread.Sleep(50);
                }
                state.morality += 30;
            }
            else        // 대성공
            {
                for (int i = 0; i < script2.Length; i++)
                {
                    Console.Write(script2[i]);
                    Thread.Sleep(50);
                }
                state.morality += 40;
            }

            Console.SetCursorPosition(5, 41);

            for (int i = 0; i < script.volunteer[3].Length; i++)
            {
                Console.Write(script.volunteer[3][i]);
                Thread.Sleep(50);
            }
            state.stress += 20;
            state.volunteerCount++;
            screen.ClickNext();
        }

        // 휴식하기 진행 함수 완성
        public void DailyOptionTwo<T>(ref T state) where T : State
        {

            screen.ClearScreen();
            art.PrintSleep();
            Console.SetCursorPosition(5, 38);

            for (int i = 0; i < script.optionTwo.Length; i++)
            {
                Console.Write(script.optionTwo[i]);
                Thread.Sleep(50);
            }
            art.PrintZ();
            screen.ClickNext();

            if (state.stress < 50)
            {
                state.stress = 0;
            }
            else
            {
                state.stress -= 50;
            }

        }

        //대화나누기 진행 함수
        public void DailyOptionThree<T>(T script) where T : Script
        {
            int num = default;
            Random random = new Random();
            screen.ClearUnder();
            Console.SetCursorPosition(5, 38);

            num = random.Next(0, script.mytalks.Count);

            for (int i = 0; i < script.mytalks[num].Length; i++)
            {
                Console.Write(script.mytalks[num][i]);
                Thread.Sleep(50);
            }

            screen.ClickNext();

            if(num == 0)
            {
                art.PrintHeart();
            }
            else if(num == 1)
            {
                art.PrintNote();
            }
            else 
            {
                art.PrintCarrot();
            }

            Console.SetCursorPosition(5, 41);

            for (int i = 0; i < script.replys[num].Length; i++)
            {
                Console.Write(script.replys[num][i]);
                Thread.Sleep(50);
            }

            Thread.Sleep(1000);

            Console.SetCursorPosition(5, 44);
            for (int i = 0; i < script.emotion[num].Length; i++)
            {
                Console.Write(script.emotion[num][i]);
                Thread.Sleep(50);
            }


            screen.ClickNext();
            screen.ClearScreen();
        }
        public void DailyOptionFour<T>(T script) where T : Script
        {
            int num = default;
            int num2 = default;
            Random random = new Random();
            screen.ClearUnder();
            

            num = random.Next(0, script.advice.Count/2);
            num2 = random.Next(script.advice.Count/2, script.advice.Count);

            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.advice[num]);

            screen.ClickNext();

            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.advice[num2]);

            screen.ClickNext();
            screen.ClearScreen();
        }
    }
}




