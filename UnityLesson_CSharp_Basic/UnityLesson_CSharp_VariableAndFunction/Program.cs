using System;

namespace UnityLesson_CSharp_VariableAndFunction
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        // CamelCase (이름 설정 규칙 중 하나)
        // class, function namespace 등은 대문자로 시작한다. 
        // 변수는 소문자로 시작한다.
        // 단어가 바뀔경우 첫 문자는 대문자로한다.
        // 줄임말은 되도록 사용하지 않는다.
        // 이름을 보았을때 어떤 기능, 목적인지 알 수 있도록 작성한다.
        // 애매한부분이 있으면 주석을 달아준다.
        class Person
        {
            int age; // 나이
            float height; // 키
            bool isFemale; // 여자인지?
            char genderChar; // 성별 문자
            string name; // 이름

            void SayAllInfo()
            {
                //Console.WriteLine($"나이 : {age}, 키 : {height}, 여자인가? : {isFemale}, 성별문자: {genderChar}, 이름 : {name}");
                SayAge();
                SayHeight();
                SayIsFemale();
                SayGenderChar();
                SayName();
            }
            void SayAge()
            {
                Console.Write($"나이 : {age}");
            }
            void SayHeight()
            {
                Console.Write($"키 : {height}");
            }
            void SayIsFemale()
            {
                Console.Write($"여자인가? : {isFemale}");
            }
            void SayGenderChar()
            {
                Console.Write($"성별문자 : {genderChar}");
            }
            void SayName()
            {
                Console.Write($"이름 : {name}");
            }
        }
    }
}
