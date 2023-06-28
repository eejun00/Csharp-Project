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

        //하루 일과 단련 스크립트
        public List<string> training = new List<string>()
        {"오늘은 단련을 하러 외곽으로 나갑니다.", "단련을 마치고 집으로 돌아갑니다... 힘들지만 보람찬 하루였습니다." };

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
