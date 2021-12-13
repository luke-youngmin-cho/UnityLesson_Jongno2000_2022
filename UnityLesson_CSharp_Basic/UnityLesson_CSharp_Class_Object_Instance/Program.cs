using System;

namespace UnityLesson_CSharp_Class_Object_Instance
{
    class Program
    {
        static void Main(string[] args)
        {
            // 객체생성 new 키워드
            // 객체를 생성했지만 메모리에 할당해주지 않았기 때문에 우리는접근할수가 없다.
            new AA();   // 생성자 : 클래스와 이름이 같은 함수 

            // 인스턴스화
            // 메모리 공간에 생성된 객체를 할당시킴. 
            // AA 타입의 a 변수에 new AA() 로 생성된 객체가 할당 되었다.
            // 이제 소프트웨어 세계에서 우리는 a 에 접근할 수있다.
            AA a = new AA(); // 클래스와 같은 이름의 함수를 생성자 라고 한다.
            // a 를 인스턴스 라고 함.

        }
        // 클래스 AA (설계도)
        public class AA
        {
        }
    }
}
