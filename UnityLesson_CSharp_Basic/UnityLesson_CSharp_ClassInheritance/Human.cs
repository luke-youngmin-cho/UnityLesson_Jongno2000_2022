using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLesson_CSharp_ClassInheritance
{
    class Human : Creature , iTwoLeggedWalker
    {
        public float height;

        // override 키워드 : 부모의 virtual 키워드가 붙은 함수를 재정의 하는 키워드
        public override void Breath()
        {
            base.Breath(); // base 키워드는 부모 클래스를 지칭함. 
            weight += 0.00002f;
            height += 0.00004f;
        }

        public void TwoLeggedWalk()
        {
            Console.WriteLine("두발로 걷는다");
        }
    }
}
