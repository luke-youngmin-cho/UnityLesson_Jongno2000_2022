using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLesson_CSharp_ClassInheritance
{
    // interface 
    // 클래스랑 비슷하게 생겼지만
    // 함수, 이벤트, 인덱서, 속성(Attribute) 만 멤버로 가질 수 있고
    // 각 멤버는 기본적으로 접근 권한자가 public 
    // 멤버들은 선언만 할 뿐 정의하지 않는다. ( 어떤 기능에 대한 이름만 명시하고 내용 구현은 안한다)
    // 클래스와 다르게 다중상속이 가능하다. 
    // 클래스의 추상화를 할때, 함수들이 같은 이름이 필요한 경우 집합으로 명시하고 따로 관리할수 있다. 
    interface iTwoLeggedWalker
    {
        void TwoLeggedWalk();
    }
}
