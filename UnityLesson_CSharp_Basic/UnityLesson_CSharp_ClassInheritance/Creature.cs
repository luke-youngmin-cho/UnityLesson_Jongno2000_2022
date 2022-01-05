using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLesson_CSharp_ClassInheritance
{
    class Creature
    {
        public string DNA;
        public int lifeTime;
        public float weight;
        // 함수 오버라이드 ( override )
        // 함수를 재정의 하는 기능
        // virtual 키워드 : 해당 함수를 오버라이딩 가능하도록 해준다. 
        // 부모클래스의 함수라고 해서 virutal 키워드를 전부 붙이는게 아니라
        // 자식클래스가 해당 함수를 재정의 해야 할 떄만 virtual 키워드를 붙여준다.
        virtual public void Breath()
        {
            lifeTime++;
        }
    }
}
