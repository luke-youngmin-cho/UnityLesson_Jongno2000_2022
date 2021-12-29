using System;

namespace UnityLesson_CSharp_ClassDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
        }
    }

    class AA
    {
        public AA() // 생성자
        {

        }

        // 가비지 컬렉터 
        // 메모리에 할당되었으나 더이상 참조되지않는 값들을 수집해서 삭제함.
        // CLR(공통 언어 런타임), .Net Framwork 의 가상 머신 구성 요소.
        // 프로그램 코드의 실행 환경을 정의하는 기능 
        // 관리되는 힙 영역 (CLR 접근 권한을 가지고있음 )
        // CLR 에 있는 가비지 컬렉터는 이 관리되는 힙 영역에서 더이상 참조되지 않는 값들을 삭제
        // 즉, 소멸자를 C# 에서 쓰지 않는 이유는
        // 생성자를 통해 AA 객체를 생성하고 함수가 종료되면 가비지컬렉터가 AA 객체를 지워준다.
    }
}
