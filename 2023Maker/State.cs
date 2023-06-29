using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023Maker
{
    public class State
    {
        public int date = 1;    //날짜
        public int strength;    //체력
        public int charm;       //매력
        public int intelligence = 80;//지능
        public int morality;    //인성
        public int stress;      //스트레스

        public int trainingCount; //단련 간 횟수
        public int downtownCount; //번화가 간 횟수
        public int schoolCount; //학교 간 횟수
        public int volunteerCount; //봉사활동 간 횟수
        public bool stressFull; //스트레스가 과한경우


    }
}
