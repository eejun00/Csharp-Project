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

        //하루 일과 번화가 스크립트
        public List<string> downtown = new List<string>()
        {"오늘은 번화가에 가기로 한 날입니다.", "오늘 나가서 갈 곳은 ", "오늘 하루도 알차게 보냈습니다. 집으로 돌아갈 시간이에요" };
        public List<string> gym = new List<string>()
        { "다른 친구들과 함께 뛰어 놀며 즐기고 있습니다." , "하루를 보내는 중 . . . ."};
        public List<string> restaurant = new List<string>()
        { "맛있는 것을 먹으며 행복해 합니다." , "하루를 보내는 중 . . . ."};
        public List<string> shopping = new List<string>()
        { "예쁜 옷이 많은 곳으로 새로운 옷을 사러 왔습니다." , "하루를 보내는 중 . . . ."};
        public List<string> bookStore = new List<string>()
        { "재밌는 책이 한가득 있습니다 서점을 돌아다니며 다양한 책을 읽습니다." , "하루를 보내는 중 . . . ."};

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

        //엔딩 스크립트
        //왕 엔딩
        public List<string> king = new List<string>() 
        {"아이는 당신의 도움으로 가장 완벽하게 자랐습니다." , 
            "강인한 체력,모두의 시선을 끄는 매력,총명한 지능,남을 헤아리는 도덕성까지...",
            "모든게 빼어난 아이는 왕위를 물려받았고,오늘부터는 이 왕국의 왕으로 살아가려고 합니다.",
        "당신덕분에 이 왕국을 다스리며 살아갈 아이를 앞으로도 응원해주세요."};

        //일반 엔딩
        public List<string> common = new List<string>()
        {"아이는 너무 평범하게 자라고 말았습니다...",
            "특별하진 않지만,지금까지 살아온 일상을 아이는 소중하게 생각하고 있습니다.",
        "아이는 앞으로의 날들도 지금까지처럼 소중히 살아가려고합니다.",        
        "평범한 일상을 보내며 살아갈 아이를 앞으로도 응원해주세요."
        };



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
