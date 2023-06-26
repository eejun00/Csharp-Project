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
        ConsoleScreen screen;

        public string prologue = "프롤로그 내용이 주루루루루루룩";


        //하루 일과 학교 스크립트
        public List<string> school = new List<string>() 
        { "오늘은 학교에 가기로 한 날입니다.", "오늘 배울 수업은 ", "열심히 배우는 중 . . . . ", "학교가 끝났습니다. 집으로 돌아갈 시간이에요" };

        //하루 일과 봉사 스크립트
        public List<string> volunteer = new List<string>()
        { "오늘은 봉사를 하러가기로 한 날입니다.", "남을 돕는 일은 도덕성에 큰 도움을 줍니다.", "열심히 봉사활동 하는 중 . . . . ", "봉사활동이 끝났습니다. 집으로 돌아갈 시간이에요" };

        //휴식 스크립트
        public string optionTwo = "아주 곤히 잠들어 편안한 하루를 보냅니다...";

        //대화 스크립트
        public List<string> mytalks = new List<string>() {"말건네기1","말건네기2","말건네기3","말건네기4"}; 
        public List<string> replys = new List<string>() { "대답1", "대답2", "대답3", "대답4"};
        public List<string> emotion = new List<string>() { "~~해보인다.", "~~해보인다.", "~~해보인다.", "~~해보인다." };





        public void PrintPrologue()
        {
            screen = new ConsoleScreen();
            Console.SetCursorPosition(4, 7);
            for (int i = 0; i< prologue.Length; i++)
            {
                Console.Write(prologue[i]);
                Thread.Sleep(50);
            }

            screen.ClickNext(); // 키 입력으로 넘어가도록

            screen.ClearScreen();  // 키 입력시 화면 안쪽만 클리어
        }
    }

    
}
