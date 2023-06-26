using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2023Maker
{
    public class Script
    {
        ConsoleScreen screen = new ConsoleScreen();
        public string prologue = "프롤로그 내용이 주루루루루루룩";


        
        public void PrintPrologue()
        {
            Console.SetCursorPosition(4, 7);
            for (int i = 0; i< prologue.Length; i++)
            {
                Console.Write(prologue[i]);
                Thread.Sleep(50);
            }

            Console.ReadKey(true); // 키 입력으로 넘어가도록

            screen.ClearScreen();  // 키 입력시 화면 안쪽만 클리어하기
        }
    }

    
}
