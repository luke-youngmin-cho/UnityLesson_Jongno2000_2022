

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReallyJustATest_NoNeedToSave
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class 검사
    {
        float HP = 100f;
        int ATK = 80;

        public void 내려찍기(Monster monster)
        {
            monster.HP = monster.HP - ATK;
        }
    }

    public class 캐릭터생성
    {
        검사 검사1 = new 검사();
        검사1.내려찍기();

    }

    class Monster
    {
        public float HP = 1000f;
    }

}
