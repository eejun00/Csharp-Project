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


        public void CompareStatForEnding<T>(T state) where T : State
        {
            int[] stats = { state.strength, state.charm, state.intelligence, state.morality }; //스탯 배열에 넣기
            int[] counts = { state.trainingCount, state.downtownCount, state.schoolCount, state.volunteerCount };
            Array.Sort(stats);
            Array.Reverse(stats);   //큰 순으로 정리
            Array.Sort(counts);
            Array.Reverse(counts);   //큰 순으로 정리

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
                    //불량배 엔딩
                }
                else if (state.strength >= 80 && state.downtownCount == 0 && state.trainingCount > 3)
                {
                    //산속으로 수련
                }
                else if (state.strength >= 80)
                {
                    // 용병 엔딩
                }
            }
            else if (stats[0] == state.charm) // 제일 높은 스탯이 매력
            {
                if (state.charm >= 80 && state.schoolCount > 0 && state.volunteerCount > 0 && stats[3] >= 30)
                {
                    //톱스타 엔딩
                }
                else if (state.charm >=80 && state.stressFull)
                {
                    //백스트리트 셀럽 엔딩
                }
                else if (state.charm >= 80 && state.schoolCount == 0)
                {
                    //광대 엔딩
                }              
                else if ((state.charm >= 80))
                {
                    //마스코트 엔딩
                }
            }
            else if (stats[0] == state.intelligence) // 제일 높은 스탯이 지능
            {
                if (state.intelligence >= 80 && state.volunteerCount > 0 && stats[3] >= 30)
                {
                    //왕국 군사 엔딩
                }
                else if (state.intelligence >= 80 && state.stressFull && state.morality <= 30)
                {
                    //독재자 엔딩
                }
                else if(state.intelligence >= 80)
                {
                    //학자 엔딩
                }
            }
            else if (stats[0] == state.morality) // 제일 높은 스탯이 도덕성
            {
                if (state.morality >= 80 && state.schoolCount > 0 && stats[3] >= 30)
                {
                    //위인 엔딩
                }
                else if(state.morality >=80 && state.stressFull)
                {
                    //사회 운동가 엔딩
                }
                else if(state.morality >= 80)
                {
                    //봉사활동가 엔딩
                }
            }

        }
        public void KingEnd() //왕 엔딩
        {
            //메인화면 프린트
            //스크립트창 프린트
            script = new Script();
            screen = new ConsoleScreen();
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

        }

        public void GreatEnd() //위인 엔딩
        {

        }

        public void ActivistEnd() //사회활동가 엔딩
        {

        }

        public void volunteerEnd() //봉사활동가 엔딩
        {

        }
    }
}
