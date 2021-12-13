using System;

namespace UnityLesson_CSharp_StaticExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.name = "김아무개";

            Person person2 = new Person();
            person2.name = "이아무개";

            Person.typeName = "사람 타입";
            Orc.typeName = "오크 타입";

            Person.SayTypeName();

            Orc orc1 = new Orc();
            //static 으로 정의된 클래스는 객체생성 불가. 인스턴스화 불가.

        }
    }
    static class Orc
    {
        static public string typeName;
    }
    class Person
    {
        // 접근제한자 : 자료형 앞에 붙여준다.
        // public, private ,protected
        // public : 다른 클래스가 접근 할수 있다.
        // private : 다른 클래스는 접근할 수 없다.
        // protected : 상속자만 접근할 수 있다. 
        public int age; // 나이
        public float height; // 키
        public bool isFemale; // 여자인지?
        public char genderChar; // 성별 문자
        public string name; // 이름

        static public string typeName; //타입이름
        static public void SayTypeName()
        {
            Console.WriteLine(typeName);
        }
        public void SayAllInfo()
        {
            //Console.WriteLine($"나이 : {age}, 키 : {height}, 여자인가? : {isFemale}, 성별문자: {genderChar}, 이름 : {name}");
            SayAge();
            SayHeight();
            SayIsFemale();
            SayGenderChar();
            SayName();
        }
        public void SayAge()
        {
            Console.Write($"나이 : {age}");
        }
        public void SayHeight()
        {
            Console.Write($"키 : {height}");
        }
        public void SayIsFemale()
        {
            Console.Write($"여자인가? : {isFemale}");
        }
        public void SayGenderChar()
        {
            Console.Write($"성별문자 : {genderChar}");
        }
        public void SayName()
        {
            Console.Write($"이름 : {name}");
        }
    }

}
