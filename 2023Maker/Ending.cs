using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2023Maker
{
    public class Ending
    {
        public int endDate = 10;
        Script script;
        ConsoleScreen screen;
        State state = new State();
        Art art = new Art();
        public List<string> stEnding = new List<string>{ "1.용사 엔딩","2.불량배 엔딩","3.수행 엔딩","4.용병 엔딩"};
        public List<string> chEnding = new List<string>{ "1.톱스타 엔딩","2.뒷세계 엔딩","3.광대 엔딩","4.마스코트 엔딩"};
        public List<string> inEnding = new List<string> { "1.책사 엔딩", "2.독재자 엔딩", "3.학자 엔딩" };
        public List<string> moEnding = new List<string> { "1.위인 엔딩", "2.사회운동가 엔딩", "3.봉사활동가 엔딩" };


        public void CompareStatForEnding<T>(T state) where T : State
        {
            screen = new ConsoleScreen();
            int[] stats = { state.strength, state.charm, state.intelligence, state.morality }; //스탯 배열에 넣기
            int[] counts = { state.trainingCount, state.downtownCount, state.schoolCount, state.volunteerCount };
            Array.Sort(stats);
            Array.Reverse(stats);   //큰 순으로 정리
            Array.Sort(counts);
            Array.Reverse(counts);   //큰 순으로 정리
            int[] stats_ = { state.strength, state.charm, state.intelligence, state.morality };
            if (stats[3] >= 70 && counts[3] >= 1)
            {
                KingEnd();
                //왕엔딩
            }
            else if (stats[0] < 80)
            {
                CommonEnd();
                //일반인 엔딩
            }
            else if (stats[0] == state.strength) // 제일 높은 스탯이 체력
            {
                if (state.strength >= 80 && stats[3] >= 30 && counts[3] >=1)
                {
                    HeroEnd();
                    //용사 엔딩
                }
                else if (state.strength >= 80 && state.stressFull && state.schoolCount == 0 && state.volunteerCount == 0)
                {
                    BlackGaurdEnd();
                    //불량배 엔딩
                }
                else if (state.strength >= 80 && state.downtownCount == 0 && state.trainingCount > 3)
                {
                    HarlemEnd();
                    //산속으로 수련
                }
                else if (state.strength >= 80)
                {
                    MercenaryEnd();
                    // 용병 엔딩
                }
            }
            else if (stats[0] == state.charm) // 제일 높은 스탯이 매력
            {
                if (state.charm >= 80 && state.schoolCount > 0 && state.volunteerCount > 0 && stats[3] >= 30)
                {
                    TopstarEnd();
                    //톱스타 엔딩
                }
                else if (state.charm >=80 && state.stressFull)
                {
                    HarlemEnd();
                    //백스트리트 셀럽 엔딩
                }
                else if (state.charm >= 80 && state.schoolCount == 0)
                {
                    ClownEnd();
                    //광대 엔딩
                }              
                else if ((state.charm >= 80))
                {
                    MascotEnd();
                    //마스코트 엔딩
                }
            }
            else if (stats[0] == state.intelligence) // 제일 높은 스탯이 지능
            {
                if (state.intelligence >= 80 && state.volunteerCount > 0 && stats[3] >= 30)
                {
                    AdvisorEnd();
                    //왕국 군사 엔딩
                }
                else if (state.intelligence >= 80 && state.stressFull && state.morality <= 30)
                {
                    DictatorEnd();
                    //독재자 엔딩
                }
                else if(state.intelligence >= 80)
                {
                    ScholarEnd();
                    //학자 엔딩
                }
            }
            else if (stats[0] == state.morality) // 제일 높은 스탯이 도덕성
            {
                if (state.morality >= 80 && state.schoolCount > 0 && stats[3] >= 30)
                {
                    GreatEnd();
                    //위인 엔딩
                }
                else if(state.morality >=80 && state.stressFull)
                {
                    ActivistEnd();
                    //사회 운동가 엔딩
                }
                else if(state.morality >= 80)
                {
                    volunteerEnd();
                    //봉사활동가 엔딩
                }
            }

            screen.ClickNext();
            screen.ClearUnder();
            SelectOtherEnd(stats[0],stats_);
            screen.ClickNext();
            screen.ClearScreen();

        }
       
        public void KingEnd() //왕 엔딩
        {
            //메인화면 프린트
            //스크립트창 프린트
            script = new Script();
            screen = new ConsoleScreen();
            screen.ClearScreen();

            art.PrintKing();

            Console.SetCursorPosition(5, 38);

            for (int i = 0; i < script.king[0].Length; i++)
            {
                Console.Write(script.king[0][i]);
                Thread.Sleep(50);
            }

            Console.SetCursorPosition(5, 41);

            for (int i = 0; i < script.king[1].Length; i++)
            {
                Console.Write(script.king[1][i]);
                Thread.Sleep(50);
            }

            screen.ClickNext();
            screen.ClearUnder();
            
            Console.SetCursorPosition(5, 38);

            for (int i = 0; i < script.king[2].Length; i++)
            {
                
                Console.Write(script.king[2][i]);
                if (script.king[2][i] == ',')
                {
                    Console.SetCursorPosition(5,40);
                }
                Thread.Sleep(50);
            }

            Console.SetCursorPosition(5, 43);

            for (int i = 0; i < script.king[3].Length; i++)
            {
                Console.Write(script.king[3][i]);
                Thread.Sleep(50);
            }


        }

        public void CommonEnd() //일반 엔딩
        {
            script = new Script();
            screen = new ConsoleScreen();

            screen.ClearScreen();

            art.PrintSecondRabbit();

            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.common[0]);

            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.common[1]);

            screen.ClickNext();
            screen.ClearUnder();

            Console.SetCursorPosition(5, 38);

            for (int i = 0; i < script.common[2].Length; i++)
            {

                Console.Write(script.common[2][i]);
                if (script.common[2][i] == ',')
                {
                    Console.SetCursorPosition(5, 40);
                }
                Thread.Sleep(50);
            }

            Console.SetCursorPosition(5, 41);

            script.PrintOneAtTime(script.common[3]);
        }

        public void HeroEnd() //용사 엔딩
        {
            script = new Script();
            screen = new ConsoleScreen();

            screen.ClearScreen();
            art.PrintFireCracker();
            art.PrintHero();
            
            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.hero[0]);

            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.hero[1]);

            screen.ClickNext();
            screen.ClearUnder();

            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.hero[2]);

            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.hero[3]);
        }

        public void BlackGaurdEnd() //불량배 엔딩
        {
            script = new Script();
            screen = new ConsoleScreen();
            screen.ClearScreen();
            art.PrintBlackGuard();

            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.blackGuard[0]);

            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.blackGuard[1]);

            screen.ClickNext();
            screen.ClearUnder();

            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.blackGuard[2]);

            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.blackGuard[3]);
        }

        public void HermitEnd() //은둔 엔딩
        {
            script = new Script();
            screen = new ConsoleScreen();
            screen.ClearScreen();
            art.PrintHermit();

            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.hermit[0]);

            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.hermit[1]);

            screen.ClickNext();
            screen.ClearUnder();

            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.hermit[2]);

            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.hermit[3]);
        }

        public void MercenaryEnd() //용병 엔딩
        {
            script = new Script();
            screen = new ConsoleScreen();
            screen.ClearScreen();
            art.PrintFireCracker();
            art.PrintMercenary();

            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.mersenary[0]);

            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.mersenary[1]);

            screen.ClickNext();
            screen.ClearUnder();

            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.mersenary[2]);

            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.mersenary[3]);
        }

        public void TopstarEnd() //톱스타 엔딩
        {
            script = new Script();
            screen = new ConsoleScreen();
            screen.ClearScreen();
            art.PrintFireCracker();
            art.PrintTopstar();

            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.topStar[0]);

            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.topStar[1]);

            screen.ClickNext();
            screen.ClearUnder();

            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.topStar[2]);

            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.topStar[3]);
        }

        public void HarlemEnd() //주점 엔딩
        {
            script = new Script();
            screen = new ConsoleScreen();
            screen.ClearScreen();
            art.PrintFireCracker();
            art.PrintHarlem();

            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.harlem[0]);

            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.harlem[1]);

            screen.ClickNext();
            screen.ClearUnder();

            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.harlem[2]);

            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.harlem[3]);
        }

        public void ClownEnd() // 광대 엔딩
        {
            script = new Script();
            screen = new ConsoleScreen();
            screen.ClearScreen();
            art.PrintFireCracker();
            art.PrintClown();

            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.clown[0]);

            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.clown[1]);

            screen.ClickNext();
            screen.ClearUnder();

            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.clown[2]);

            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.clown[3]);
        }

        public void MascotEnd() // 마스코트 엔딩
        {
            script = new Script();
            screen = new ConsoleScreen();
            screen.ClearScreen();
            art.PrintFireCracker();
            art.PrintMascot();
            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.mascot[0]);

            Console.SetCursorPosition(5, 41);
            for (int i = 0; i < script.mascot[1].Length; i++)
            {

                Console.Write(script.mascot[1][i]);
                if (script.mascot[1][i] == ',')
                {
                    Console.SetCursorPosition(5, 43);
                }
                Thread.Sleep(50);
            }

            screen.ClickNext();
            screen.ClearUnder();

            Console.SetCursorPosition(4, 38);
            script.PrintOneAtTime(script.mascot[2]);

            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.mascot[3]);
        }

        public void AdvisorEnd() // 군사,참모 엔딩
        {
            script = new Script();
            screen = new ConsoleScreen();
            screen.ClearScreen();
            art.PrintFireCracker();
            art.PrintAdvisor();

            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.advisor[0]);

            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.advisor[1]);

            screen.ClickNext();
            screen.ClearUnder();

            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.advisor[2]);

            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.advisor[3]);
        }

        public void DictatorEnd() // 독재자 엔딩
        {
            script = new Script();
            screen = new ConsoleScreen();
            screen.ClearScreen();
            art.PrintDictator();

            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.dictator[0]);

            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.dictator[1]);

            screen.ClickNext();
            screen.ClearUnder();

            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.dictator[2]);

            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.dictator[3]);
        }

        public void ScholarEnd() // 학자 엔딩
        {
            script = new Script();
            screen = new ConsoleScreen();
            screen.ClearScreen();
            art.PrintFireCracker();
            art.PrintSchola();

            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.scholar[0]);

            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.scholar[1]);

            screen.ClickNext();
            screen.ClearUnder();

            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.scholar[2]);

            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.scholar[3]);
        }

        public void GreatEnd() //위인 엔딩
        {
            script = new Script();
            screen = new ConsoleScreen();
            screen.ClearScreen();
            art.PrintFireCracker();
            art.PrintGreat();

            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.great[0]);

            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.great[1]);

            screen.ClickNext();
            screen.ClearUnder();

            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.great[2]);

            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.great[3]);
        }

        public void ActivistEnd() //사회활동가 엔딩
        {
            script = new Script();
            screen = new ConsoleScreen();
            screen.ClearScreen();
            art.PrintFireCracker();
            art.PrintActivist();

            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.activist[0]);

            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.activist[1]);

            screen.ClickNext();
            screen.ClearUnder();

            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.activist[2]);

            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.activist[3]);
        }

        public void volunteerEnd() //봉사활동가 엔딩
        {
            script = new Script();
            screen = new ConsoleScreen();
            screen.ClearScreen();
            art.PrintFireCracker();
            art.PrintVolunteer();

            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.volunteerStr[0]);

            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.volunteerStr[1]);

            screen.ClickNext();
            screen.ClearUnder();

            Console.SetCursorPosition(5, 38);
            script.PrintOneAtTime(script.volunteerStr[2]);

            Console.SetCursorPosition(5, 41);
            script.PrintOneAtTime(script.volunteerStr[3]);
        }

        public void SelectOtherEnd(int highStat, int[] stats_)
        {
            string question = "클리어한 엔딩과 비슷한 루트의 엔딩도 보시겠어요? (Q입력시 종료)";
            script = new Script();
            screen = new ConsoleScreen();
            
            char stat = default;

            Console.SetCursorPosition(12, 37);
            script.PrintOneAtTime(question);

            if(highStat == stats_[0])
            {
                screen.PrintOption2(stEnding);
                stat = 's';
            }
            else if(highStat == stats_[1])
            {
                screen.PrintOption2(chEnding);
                stat = 'c';
            }
            else if(highStat == stats_[2])
            {
                screen.PrintOption2(inEnding);
                stat = 'i';
            }
            else if(highStat == stats_[3])
            {
                screen.PrintOption2(moEnding);
                stat = 'm';
            }
            else
            {

            }

            bool answer = true;
            bool answer2 = true;
            while (answer2)
            {
                answer = true;
                while (answer)  // 선택지를 결정할때까지 반복
                {
                    Console.SetCursorPosition(12, 37);
                    script.PrintOneAtTime(question);

                    if (highStat == stats_[0])
                    {
                        screen.PrintOption2(stEnding);
                        stat = 's';
                    }
                    else if (highStat == stats_[1])
                    {
                        screen.PrintOption2(chEnding);
                        stat = 'c';
                    }
                    else if (highStat == stats_[2])
                    {
                        screen.PrintOption2(inEnding);
                        stat = 'i';
                    }
                    else if (highStat == stats_[3])
                    {
                        screen.PrintOption2(moEnding);
                        stat = 'm';
                    }
                    else
                    {

                    }
                    System.ConsoleKeyInfo select1 = Console.ReadKey(true);

                    switch (select1.Key)
                    {
                        case ConsoleKey.NumPad1:
                            if (stat == 's')
                            {
                                if (screen.AskAgain2(stEnding[0]))
                                {
                                    HeroEnd();
                                    //선택지 진행
                                    answer = false;
                                }
                            }
                            else if (stat == 'c')
                            {
                                if (screen.AskAgain2(chEnding[0]))
                                {
                                    TopstarEnd();
                                    //선택지 진행
                                    answer = false;
                                }
                            }
                            else if (stat == 'i')
                            {
                                if (screen.AskAgain2(inEnding[0]))
                                {
                                    AdvisorEnd();
                                    //선택지 진행
                                    answer = false;
                                }
                            }
                            else if (stat == 'm')
                            {
                                if (screen.AskAgain2(moEnding[0]))
                                {
                                    GreatEnd();
                                    //선택지 진행
                                    answer = false;
                                }
                            }
                            break;

                        case ConsoleKey.NumPad2:
                            if (stat == 's')
                            {
                                if (screen.AskAgain2(stEnding[1]))
                                {
                                    BlackGaurdEnd();
                                    //선택지 진행
                                    answer = false;
                                }
                            }
                            else if (stat == 'c')
                            {
                                if (screen.AskAgain2(chEnding[1]))
                                {
                                    HarlemEnd();
                                    //선택지 진행
                                    answer = false;
                                }
                            }
                            else if (stat == 'i')
                            {
                                if (screen.AskAgain2(inEnding[1]))
                                {
                                    DictatorEnd();
                                    //선택지 진행
                                    answer = false;
                                }
                            }
                            else if (stat == 'm')
                            {
                                if (screen.AskAgain2(moEnding[1]))
                                {
                                    ActivistEnd();
                                    //선택지 진행
                                    answer = false;
                                }
                            }
                            break;

                        case ConsoleKey.NumPad3:
                            if (stat == 's')
                            {
                                if (screen.AskAgain2(stEnding[2]))
                                {
                                    HermitEnd();
                                    //선택지 진행
                                    answer = false;
                                }
                            }
                            else if (stat == 'c')
                            {
                                if (screen.AskAgain2(chEnding[2]))
                                {
                                    ClownEnd();
                                    //선택지 진행
                                    answer = false;
                                }
                            }
                            else if (stat == 'i')
                            {
                                if (screen.AskAgain2(inEnding[2]))
                                {
                                    ScholarEnd();
                                    //선택지 진행
                                    answer = false;
                                }
                            }
                            else if (stat == 'm')
                            {
                                if (screen.AskAgain2(moEnding[2]))
                                {
                                    volunteerEnd();
                                    //선택지 진행
                                    answer = false;
                                }
                            }
                            break;

                        case ConsoleKey.NumPad4:
                            if (stat == 's')
                            {
                                if (screen.AskAgain2(stEnding[2]))
                                {
                                    MercenaryEnd();
                                    //선택지 진행
                                    answer = false;
                                }
                            }
                            else if (stat == 'c')
                            {
                                if (screen.AskAgain2(chEnding[2]))
                                {
                                    MascotEnd();
                                    //선택지 진행
                                    answer = false;
                                }
                            }
                            else
                            {
                                /*Pass*/
                            }
                            break;

                        case ConsoleKey.Q:
                            answer = false;
                            answer2 = false;
                            break;
                        default:
                            break;
                    }
                }
                if (answer2)
                {
                    screen.ClickNext();
                    screen.ClearUnder();                    
                }
            }
        }
    }
}
