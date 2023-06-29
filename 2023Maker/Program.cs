using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2023Maker
{
    public class Program
    {
        static void Main(string[] args)
        {
            Maker();
        }

        static void Maker()
        {
            Console.CursorVisible = false;  //커서 안보이게 하기

            State state = new State();
            ConsoleScreen screen = new ConsoleScreen();
            Script script = new Script();
            Daily daily = new Daily();
            Ending ending = new Ending();
            Map map = new Map();
            Art art = new Art();

            //게임 화면이 잘보이게 하기위해 콘솔 사이즈 조정
            Console.SetWindowSize(150, 50);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            while (true)
            {
                // 게임 시작 화면
                screen.StartScreen();

                //게임 프롤로그 구현
                screen.MainScreen();               
                script.PrintPrologue();
                screen.ClearScreen();


                //게임 진행 메인화면 출력
                screen.Status(state);
                art.PrintFirstRabbit();                
                screen.PrintBigOption(daily);                              

                while (state.date < ending.endDate)
                {

                    bool answer = true;

                    while (answer)  // 선택지를 결정할때까지 반복
                    {
                        System.ConsoleKeyInfo select1 = Console.ReadKey(true);

                        switch (select1.Key)
                        {
                            case ConsoleKey.NumPad1:

                                screen.ClearUnder();
                                screen.PrintOption(daily);

                                System.ConsoleKeyInfo select2 = Console.ReadKey(true);

                                switch (select2.Key)
                                {
                                    case ConsoleKey.NumPad1:
                                        if (screen.AskAgain(daily.firstOption))
                                        {
                                            //선택지 진행
                                            daily.FirstDailyOption(ref state);
                                            answer = false;
                                        }
                                        break;

                                    case ConsoleKey.NumPad2:
                                        if (screen.AskAgain(daily.secondOption))
                                        {
                                            //선택지 진행
                                            daily.SecondDailyOption(ref state);
                                            answer = false;
                                        }

                                        break;

                                    case ConsoleKey.NumPad3:
                                        if (screen.AskAgain(daily.thirdOption))
                                        {
                                            //선택지 진행
                                            daily.ThirdDailyOption(ref state);
                                            answer = false;
                                        }
                                        break;

                                    case ConsoleKey.NumPad4:
                                        if (screen.AskAgain(daily.fourthOption))
                                        {
                                            //선택지 진행
                                            daily.FourthDailyOption(ref state);
                                            answer = false;
                                        }
                                        break;
                                    default:
                                        break;


                                }
                                break;
                            case ConsoleKey.NumPad2:
                                if (screen.AskAgain(daily.optionTwo))
                                {
                                    daily.DailyOptionTwo(ref state);
                                    //선택지 진행
                                    answer = false;
                                }
                                break;
                            case ConsoleKey.NumPad3:
                                if (screen.AskAgain(daily.optionThree))
                                {
                                    daily.DailyOptionThree(script);
                                    //선택지 진행
                                    state.date -= 1;
                                    answer = false;
                                }
                                break;
                            case ConsoleKey.NumPad4:
                                if (screen.AskAgain(daily.optionFour))
                                {
                                    //선택지 진행
                                    answer = false;
                                }
                                break;

                            default:
                                break;
                        }
                    }   //선택지 고르는 와일문 종료 부분

                    //날짜 증가
                    state.date += 1;
                    if (state.stress >= 80)
                    {
                        state.stressFull = true;
                    }
                    screen.ClearScreen();
                    screen.Status(state);
                    screen.MainScreen();
                    if(state.date < 5)
                    {
                        art.PrintFirstRabbit();
                    }
                    else if(state.date == 5)
                    {
                        art.PrintGrowUP();
                    }
                    else
                    {
                        art.PrintSecondRabbit();
                    }
                    screen.PrintBigOption(daily);

                }

                screen.ClearScreen();
                screen.MainScreen();
                ending.CompareStatForEnding(state);

                screen.ClickNext();

                bool reGame = true;
                while (reGame)
                {
                    screen.ClearUnder();
                    string reGameStr = "새로운 게임을 시작하시겠습니까? (Y/N)";
                    string yStr = "잠시 후 게임이 다시 시작됩니다. . .";
                    string nStr = "게임을 종료합니다.";
                    string wrong = "잘못된 입력입니다.";
                    Console.SetCursorPosition(25, 41);
                    for (int i = 0; i < reGameStr.Length; i++)
                    {
                        Console.Write(reGameStr[i]);
                    }
                    System.ConsoleKeyInfo key = Console.ReadKey(true);

                    Console.SetCursorPosition(25, 44);
                    switch (key.Key)
                    {
                        case ConsoleKey.Y:
                            for (int i = 0; i < yStr.Length; i++)
                            {
                                if (yStr[i] == '.')
                                {
                                    Console.Write(yStr[i]);
                                    Thread.Sleep(1000);
                                }
                                else
                                {
                                    Console.Write(yStr[i]);
                                    Thread.Sleep(50);
                                }
                            }
                            reGame = false;
                            break;
                        case ConsoleKey.N:
                            for(int i = 0; i < nStr.Length; i++)
                            {
                                Console.Write(nStr[i]);
                                Thread.Sleep(50);
                            }
                            Thread.Sleep(500);
                            return;
                        default:
                            for (int i = 0; i < wrong.Length; i++)
                            {
                                Console.Write(wrong[i]);
                                Thread.Sleep(50);
                            }
                            Thread.Sleep(1000);
                            break;
                    }

                }
                Console.Clear();
            }


        }
    }
}