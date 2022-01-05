using System;
using System.Collections.Generic;

namespace UnityLesson_CSharp_ClassInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Creature creature = new Creature();
            creature.Breath();

            Human human = new Human();
            human.Breath();

            Dog dog = new Dog();
            dog.Breath();

            // 황인,백인,흑인을 두발로 걷게 하고싶다~
            //=================================================

            // 그냥 객체 멤버 함수 호출
            YellowMan yellowMan1 = new YellowMan();
            BlackMan blackMan1 = new BlackMan();
            WhiteMan whiteMan1 = new WhiteMan();

            yellowMan1.TwoLeggedWalk();
            blackMan1.TwoLeggedWalk();
            whiteMan1.TwoLeggedWalk();

            // 인터페이스 활용
            iTwoLeggedWalker yellowMan1_iTwoLeggedWalker = yellowMan1;
            iTwoLeggedWalker blackMan1_iTwoLeggedWalker = blackMan1;
            iTwoLeggedWalker whiteMan1_iTwoLeggedWalker = whiteMan1;

            List<iTwoLeggedWalker> list_TwoLeggedWalker = new List<iTwoLeggedWalker>();
            list_TwoLeggedWalker.Add(yellowMan1_iTwoLeggedWalker);
            list_TwoLeggedWalker.Add(blackMan1_iTwoLeggedWalker);
            list_TwoLeggedWalker.Add(whiteMan1_iTwoLeggedWalker);

            foreach (iTwoLeggedWalker twoLeggedWalker in list_TwoLeggedWalker)
            {
                twoLeggedWalker.TwoLeggedWalk();
            }
            

        }
    }
}
