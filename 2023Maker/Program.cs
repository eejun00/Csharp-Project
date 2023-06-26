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
            State state = new State();
            //Console.CursorVisible = false;
            ConsoleScreen screen = new ConsoleScreen();
            Script script = new Script();

            //게임 화면이 잘보이게 하기위해 콘솔 사이즈 조정
            Console.SetWindowSize(150, 50);

            // 게임 시작 화면
            screen.StartScreen();

            //게임 프롤로그 구현
            screen.MainScreen();
            script.PrintPrologue();


            //게임 진행 메인화면 출력
            screen.Status(state);
            //screen.MainScreen();
        }
    }
}
