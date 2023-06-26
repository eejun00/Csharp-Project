using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            //게임 화면이 잘보이게 하기위해 콘솔 사이즈 조정
            Console.SetWindowSize(150, 50);

            // 게임 시작 화면
            screen.StartScreen();

            //게임 프롤로그 구현
            screen.MainScreen();
            script.PrintPrologue();


            //게임 진행 메인화면 출력
            screen.Status(state);
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
                                        answer = false;
                                    }
                                    break;

                                case ConsoleKey.NumPad2:
                                    if (screen.AskAgain(daily.secondOption))
                                    {
                                        //선택지 진행
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

                state.date += 1;

                screen.ClearScreen();
                screen.Status(state);
                screen.MainScreen();
                screen.PrintBigOption(daily);

            }       


        }
    }
}

