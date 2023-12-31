﻿using System;
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
        Art art;

        public List<string> prologue = new List<string>() {"당신은 언제나 처럼 하루를 보내고 집으로 돌아가던 중이었습니다.",
        "길을 걷던 도중, 수풀에서 소리가 들려 옆을 보았고,","그곳에는 작고 귀여운 토끼가 당신을 바라보고 있었습니다.",
        "토끼와 잠시 눈을 마주치자 토끼는 사라졌고, 당신은 그대로 집으로 돌아왔습니다.",
        "\"이 아이를 도와주세요.\""," \"...!\"","갑자기 들려온 목소리에 주변을 둘러보니,","바닥엔 아까 마주친 토끼가 있었습니다.",
        "귀여운 토끼를 내버려둘수 없었던 당신은, 오늘부터 토끼와 함께 지내기로 합니다."};

        public string growUp = "아이가 시간이 지남에 따라 성장했습니다!!";

        //하루 일과 단련 스크립트
        public List<string> training = new List<string>()
        {"오늘은 단련을 하러 외곽으로 나갑니다.", "중간에 그만두려면 Q를 입력해주세요.", "단련을 마치고 집으로 돌아갑니다... 힘들지만 보람찬 하루였습니다." };

        //하루 일과 번화가 스크립트
        public List<string> downtown = new List<string>()
        {"오늘은 번화가에 가기로 한 날입니다.", "오늘 나가서 갈 곳은 ", "오늘 하루도 알차게 보냈습니다. 집으로 돌아갈 시간이에요." };
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
        { "오늘은 학교에 가기로 한 날입니다.", "오늘 배울 수업은 ", "책상에 앉아 열심히 배우는 중 . . . . ", "학교가 끝났습니다. 집으로 돌아갈 시간이에요" };

        //하루 일과 봉사 스크립트
        public List<string> volunteer = new List<string>()
        { "오늘은 봉사를 하러가기로 한 날입니다.", "남을 돕는 일은 도덕성에 큰 도움을 줍니다.", "쓰레기 주워서 버리는 중 . . . . ", "봉사활동이 끝났습니다. 집으로 돌아갈 시간이에요" };

        //휴식 스크립트
        public string optionTwo = "아주 곤히 잠들어 편안한 하루를 보냅니다...";

        //대화 스크립트
        public List<string> mytalks = new List<string>() {"아이에게 사랑한다고 말해주었다.","아이에게 노래를 짧게 해주었다","아이에게 당근을 좋아하냐고 물었다.",}; 
        public List<string> replys = new List<string>() { "아이도 자신도 그렇다는듯 웃어보였다.", "내 노래를 들으며 신난 표정을 지었다.", "머릿속으로 당근을 떠올린듯한 표정이다."};
        public List<string> emotion = new List<string>() { "아이가 행복해보인다.", "아이가 신나보인다.", "아이가 배고파보인다."};

        //조언 스크립트
        public List<string> advice = new List<string>() {"아이의 능력을 골고루 키워줄수록, 커서 좋은 아이가 됩니다.",
        "스트레스를 적당히 조절해주지 않으면, 아이가 나쁜길로 접어들수 있습니다.",
        "휴식을 취하면 하루가 지나가지만, 스트레스가 50 감소합니다.",
        "봉사활동을 갈때, 운이 좋다면 평소보다 도덕성이 10이나 더 증가합니다.",
        "번화가에서 갈 수 있는곳은 체육관, 음식점, 서점, 옷가게가 있습니다.",
        "학교에서 배울 수 있는 과목으론 체육, 미술, 학문, 예법이 있습니다.",
        "단련을 가서 몬스터 3마리를 전부 잡으면, 체력이 더 상승합니다.",
        "아이는 10일이 지나면, 자신의 길을 찾아 떠나게됩니다."
        };

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

        //용사 엔딩
        public List<string> hero = new List<string>()
        {"아이는 꾸준한 단련과 동시에 다른 부분도 게을리 하지않았습니다.",
        "이제 다른이들을 지키기 위해 아이는 용사가 되기로 결심했습니다.",
        "용사가 된 아이는 왕국을 떠나 위협에 맞써 싸워나가려고 합니다.",
        "용사로서 위협과 맞서 싸우고 희망찬 여정을 이어갈 아이를 응원해주세요."};

        //불량배 엔딩
        public List<string> blackGuard = new List<string>()
        {"아이는 열심히 체력을 길렀지만, 정의로운 방향으로 사용하고 싶어하지 않습니다.",
            "오늘 외출로 마을 광장의 나무를 두토막 냈다는 얘기를 자연스럽게 얘기합니다..",
            "불량배가 된 아이는 더 이상 당신의 말을 듣지않고 자유롭게 살기를 원합니다.",
            "비록 불량배가 됐지만, 앞으로 어떻게든 살아갈 아이를 응원해주세요."};

        //은둔 엔딩
        public List<string> hermit = new List<string>()
        {"아이는 단련을 열심히 했지만, 마을의 문화에 어울리지 못했습니다.",
            "마을에 적응하지 못하고, 단련을 계속하기 위한 방법을 찾은 아이는,",
        "이제 마을을 떠나 자연으로 돌아가 계속 수행을 쌓길 원하고 있습니다.",
        "이제 만나긴 힘들겠지만, 자연에서 자신을 단련하고 수행할 아이를 응원해주세요."
        };

        //용병 엔딩
        public List<string> mersenary = new List<string>()
        {"아이는 단련과 여러 활동으로 용사를 꿈꿨지만 용사에는 닿지 못했습니다.",
            "하지만 다른 방식으로라도 왕국을 지키며 살아가길 원하고 있습니다.",
            "그래서 용병이 되어서라도 적과 맞서 싸우며 정의를 실현하려고 합니다.",
            "용병으로서 위협과 맞서 싸우고 하루하루 용사를 꿈꿀 아이를 응원해주세요."};

        //톱스타 엔딩
        public List<string> topStar = new List<string>() 
        {"아이는 자신을 가꾸고 모든부분을 노력해 왕국 제일가는 톱스타가 되었습니다.", 
        "아이의 웃음에 사람들이 행복해하고, 노래에 왕국의 평화로움이 느껴집니다.",
        "아이는 왕국 제일가는 스타로서 사람들에게 행복을 나눠주길 원합니다.",
        "톱스타로서 사람들에게 행복을 나눠주며 살아갈 아이를 응원해주세요."};

        //뒷골목스타 엔딩
        public List<string> harlem = new List<string>() 
        {"아이는 상당히 매력적인 사람이지만, 스트레스로 어딘가 빛이 바래버렸습니다..",
            "당신이 모르는 사이 아이는, 뒷세계에서 유명인이 되어있었습니다.",
            "비록 모두가 알지는 못하지만, 일부에겐 이미 멋진 사람이 됐습니다.",
            "아이가 원하는 장소에서 사람들을 행복하게 하는 아이를 앞으로도 응원해주세요."
        };

        //광대 엔딩
        public List<string> clown = new List<string>() 
        {"아이는 자신의 매력으로 사람들을 행복하게 하지만, 배움이 부족했습니다..",
        "하지만 자신의 능력을 최대한으로 활용해서라도 행복을 나눠주고 싶어합니다.",
        "그런 아이는 광대로서라도 사람들 앞에 서기로 결심합니다.",
        "사람들에게 웃음과 행복을 주며 살아갈 아이를 앞으로도 응원해주세요."
        };

        //마스코트 엔딩
        public List<string> mascot = new List<string>() 
        {"아이는 다른부분은 평범해도, 항상 주변에 빛이 나고 다른이들을 웃게합니다.",
        "아이는 여전히 일상을 보내고 있음에도,다른이들은 아이를 보는것만으로 행복해합니다.",
        "어느새 마을의 마스코트가 되어있었지만, 그래도 아이는 일상을 살아가려고 합니다.",
        "평범한 일상을 살면서도 사람들에게 행복을 주는 아이를 앞으로도 응원해주세요."};

        //왕국 군사 엔딩
        public List<string> advisor = new List<string>()
        {"아이는 너무나도 총명해졌고 다른부분도 충분히 강해졌습니다.",
        "아이의 재능을 알아본 왕국은 아이가 왕국의 발전에 기여해주길 원합니다.",
        "아이는 그 요청을 수락했고, 오늘부터 왕국의 책사로서 살아가려고 합니다.",
        "빛나는 총명함으로 왕국을 발전시켜나갈 아이를 앞으로도 응원해주세요."};

        //독재자 엔딩
        public List<string> dictator = new List<string>() 
        {"아이는 너무나도 총명하지만, 스트레스로 비뚤어진 관점으로 세상을 바라봅니다.",
        "명석한 두뇌로 수단과 방법을 가리지 않아 결국 자신만의 왕국을 만들고맙니다.",
        "이제 아이는 자신의 왕국에서 독재자로서 군림하여 살아가려고 합니다.",
        "비록 독재자지만 자신이 정한 꿈을 이뤄 살아가는 아이를 응원해주세요."};

        //학자 엔딩
        public List<string> scholar = new List<string>()
        {"아이의 다른부분은 몰라도, 높은 지능만큼은 누구도 따라올수 없습니다.",
        "지금까지 많은 학문을 배우고, 앞으로도 계속 성장해 나갈것입니다.",
        "그러기 위해 아이는 지식을 탐구하는 학자가 되길 원하고 있습니다.",
        "당신의 도움으로 학문을 탐구하는 학자가 될 아이를 응원해주세요."};


        //위인 엔딩
        public List<string> great = new List<string>()
        {"아이는 개인능력이 뛰어남에도 남에게 베푸는 마음을 잊지 않았습니다.",
        "그런 아이의 이야기는 모두에게 전해졌고, 아이는 위인이 되었습니다.",
        "아이는 앞으로도 많은 사람들에게 자신의 능력을 베풀기를 원합니다.",
        "당신의 도음으로 위인이 된 아이의 미래를 앞으로도 응원해주세요."};

        //사회운동가 엔딩
        public List<string> activist = new List<string>()
        {"아이는 도덕적 관념은 뛰어나지만, 세상에 불만이 있습니다.",
        "그런 아이는 자신만의 도덕적 관념을 굽히지 않으려 하였고,",
        "그 관념을 바탕으로 이 사회를 바꾸는 일에 도전하려고 합니다.",
        "아이는 잘못이 없습니다. 앞으로도 아이를 응원해주시길 바랍니다."};

        //봉사활동가 엔딩
        public List<string> volunteerStr = new List<string>()
        {"아이는 지금까지 꾸준히 해온 봉사정신을 잊지 않았습니다.",
        "봉사활동을 하면서 자신이 하고싶은 일을 찾은것 같습니다.",
        "아이는 앞으로도 타인을 돕고 베푸는 일을 하고 싶어합니다.",
        "앞으로 봉사활동가가 되어서 살아갈 아이를 앞으로도 응원해주세요."};
        public void PrintOneAtTime(string script)
        {
            for(int i = 0; i < script.Length; i++)
            {
                Console.Write(script[i]);
                Thread.Sleep(50);
            }
        }

        public void PrintPrologue()
        {
            screen = new ConsoleScreen();
            art = new Art();

            Console.SetCursorPosition(4, 8);
            PrintOneAtTime(prologue[0]);
            Thread.Sleep(500);
            Console.SetCursorPosition(4, 11);
            PrintOneAtTime(prologue[1]);
            Thread.Sleep(500);
            Console.SetCursorPosition(4, 14);
            PrintOneAtTime(prologue[2]);

            art.PrintPrologue();


            screen.ClickNext(); // 키 입력으로 넘어가도록

            screen.ClearScreen();  // 키 입력시 화면 안쪽만 클리어


            Console.SetCursorPosition(4, 8);
            PrintOneAtTime(prologue[3]);
            Thread.Sleep(500);
            Console.SetCursorPosition(4, 10);
            PrintOneAtTime(prologue[4]);
            Thread.Sleep(500);
            Console.SetCursorPosition(4, 12);
            PrintOneAtTime(prologue[5]);
            Thread.Sleep(500);
            Console.SetCursorPosition(4, 14);
            PrintOneAtTime(prologue[6]);
            Thread.Sleep(500);
            Console.SetCursorPosition(4, 16);
            PrintOneAtTime(prologue[7]);

            art.PrintPrologue2();
            Thread.Sleep(800);
            Console.SetCursorPosition(4, 18);
            PrintOneAtTime(prologue[8]);

            screen.ClickNext(); // 키 입력으로 넘어가도록

            screen.ClearScreen();  // 키 입력시 화면 안쪽만 클리어

        }


    }

    
}
