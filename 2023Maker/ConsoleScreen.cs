using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2023Maker
{
    public class ConsoleScreen
    {
        State state;
        Daily daily;

        //큰 화면 프린트 시작 (4,6) //큰 화면 프린트 끝 (80,35)
        //밑 화면 프린트 시작 (4,37) //밑 화면 프린트 끝 (80,46)
        public void StartScreen()   // 시작화면 기능만 있음. 시간날때 꾸미기
        {
            Console.SetCursorPosition(15, 30);
            Console.WriteLine("Press any key to start the game");
            Console.ReadKey();
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < 35; i++)
            {
                Console.WriteLine("                                                                                                                                                                                                                     ");
                Thread.Sleep(20);
            }
        }
        public void ClearScreen()   //메인 화면 테두리를 제외한 클리어 함수
        {
            
            for (int i = 0; i< 30; i++)
            {
                Console.SetCursorPosition(4, i+6);
                Console.WriteLine("                                                                              ");
            }
            
            for (int i = 0; i< 10; i++)
            {
                Console.SetCursorPosition(4, i+37);
                Console.WriteLine("                                                                             ");
            }
        }

        public void ClearUnder()    //밑 콘솔창만 지우기
        {
            for (int i = 0; i< 10; i++)
            {
                Console.SetCursorPosition(4, i+37);
                Console.WriteLine("                                                                             ");
            }
        }

        //게임 진행 스크립트 넘길때 입력이 필요한 경우 사용
        public void ClickNext()
        {
            Console.SetCursorPosition(78, 45);
            Console.Write("▼");
            Console.ReadKey(true);
            Console.SetCursorPosition(78, 45);
            Console.Write("   ");


        }

        public void Status<T>(T state) where T : State // 날짜, 스탯 출력하는 함수
        {
            Console.SetCursorPosition(0, 1);
            Console.Write("  오늘의 날짜      ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("{0}일차\n",state.date);
            Console.ResetColor();
            Console.WriteLine();
            Console.Write("  체력 ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("♥ {0}   ", state.strength);
            Console.ResetColor();            
            Console.Write("매력 ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("♬ {0}   ", state.charm);
            Console.ResetColor();
            Console.Write("지능 ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("◆ {0}   ", state.intelligence);
            Console.ResetColor();
            Console.Write("도덕성 ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("♣ {0}   ", state.morality);
            Console.ResetColor();
            Console.Write("스트레스 ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("♨ {0}", state.stress);
            Console.ResetColor();


            Console.WriteLine("");
        }

        public void MainScreen()    //메인 스크린 디자인 출력 함수
        {
            Console.SetCursorPosition(82, 5);
            Console.Write("┐");
            Console.SetCursorPosition(1, 5);
            Console.Write("┌");
            Console.SetCursorPosition(1, 36);
            Console.Write("└");
            Console.SetCursorPosition(82, 36);
            Console.Write("┘");
            Console.SetCursorPosition(1, 47);
            Console.Write("└");
            Console.SetCursorPosition(82, 47);
            Console.Write("┘");
            for (int i = 0; i < 80; i++)
            {
                Console.SetCursorPosition(2+i, 5);
                Console.Write("━");
                Console.SetCursorPosition(2+i, 36);
                Console.Write("━");
                Console.SetCursorPosition(2+i, 47);
                Console.Write("━");
                //Thread.Sleep(1);
                if (i <= 40)
                {
                    Console.SetCursorPosition(0, i+6);
                    Console.Write(" │");
                    Console.SetCursorPosition(82, i+6);
                    Console.Write("│");
                    Thread.Sleep(1);
                }
            }
            Console.WriteLine();
        }

        public void PrintBigOption<T>(T daily) where T : Daily
        {           
            Console.SetCursorPosition(12, 39);
            Console.Write(daily.optionOne);
            Console.SetCursorPosition(54, 39);
            Console.Write(daily.optionTwo);
            Console.SetCursorPosition(12, 42);
            Console.Write(daily.optionThree);
            Console.SetCursorPosition(54, 42);
            Console.Write(daily.optionFour);
        }

        public void PrintOption<T>(T daily) where T : Daily
        {
            Console.SetCursorPosition(12, 39);
            Console.Write(daily.firstOption);
            Console.SetCursorPosition(54, 39);
            Console.Write(daily.secondOption);
            Console.SetCursorPosition(12, 42);
            Console.Write(daily.thirdOption);
            Console.SetCursorPosition(54, 42);
            Console.Write(daily.fourthOption);
        }

        public void PrintOption2(List<string> strings)
        { 
            Console.SetCursorPosition(12, 39);
            Console.Write(strings[0]);
            Console.SetCursorPosition(54, 39);
            Console.Write(strings[1]);
            Console.SetCursorPosition(12, 42);
            Console.Write(strings[2]);
            if (strings.Count > 3)
            {
                Console.SetCursorPosition(54, 42);
                Console.Write(strings[3]);
            }
        }

        public bool AskAgain(string option)
        {
            daily = new Daily();
            Console.SetCursorPosition(10, 45);
            string question = "로 결정하시겠습니까? 결정하시려면 엔터를 눌러주세요.";
            for (int i = 0; i< option.Length; i++)
            {
                Console.Write(option[i]);
                Thread.Sleep(10);
            }
            for (int i = 0; i< question.Length; i++)
            {                
                Console.Write(question[i]);
                Thread.Sleep(10);
            }
            System.ConsoleKeyInfo reselect = Console.ReadKey(true);
            switch (reselect.Key)
            {
                case ConsoleKey.Enter:
                    return true;
                default:
                    ClearUnder();
                    PrintBigOption(daily);
                    return false;
            }
        }

        public bool AskAgain2(string option)
        {
            daily = new Daily();
            Console.SetCursorPosition(10, 45);
            string question = "로 결정하시겠습니까? 결정하시려면 엔터를 눌러주세요.";
            for (int i = 0; i< option.Length; i++)
            {
                Console.Write(option[i]);
                Thread.Sleep(10);
            }
            for (int i = 0; i< question.Length; i++)
            {
                Console.Write(question[i]);
                Thread.Sleep(10);
            }
            System.ConsoleKeyInfo reselect = Console.ReadKey(true);
            switch (reselect.Key)
            {
                case ConsoleKey.Enter:
                    return true;
                default:
                    ClearUnder();                    
                    return false;
            }
        }

    }
}
