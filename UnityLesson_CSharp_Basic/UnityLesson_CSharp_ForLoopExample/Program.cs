using System;
// Orc 객체를 10명 만들고, 오크들의 인스턴스는 Orc타입 배열에 넣어준다.
// 각 오크의 이름은 오크0, 오크1, ....오크9 
// 각 오크에게 랜덤한 isResting 값을 설정해준다 (true or false)
// 각 오크가 쉬고있으면 점프시키고 쉬지않고있으면 아무것도 안시킨다.
namespace UnityLesson_CSharp_ForLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Orc[] arr_Orc = new Orc[10];
            int length = arr_Orc.Length;
            for (int i = 0;
                i < length;
                i++)
            {
                arr_Orc[i] = new Orc();
                arr_Orc[i].name = $"오크{i}";
                arr_Orc[i].isResting = GetRandomBool();
            }
            for (int i = 0; i < length; i++)
            {
                if (arr_Orc[i].isResting)
                {
                    arr_Orc[i].Jump();
                }
            }
                        
        }

        static public bool GetRandomBool()
        {
            Random rand = new Random();
            int randInt = rand.Next(0, 2);
            bool value = Convert.ToBoolean(randInt); // Next 함수는 minValue ~ maxValue - 1 범위 값을 반환. 0,2 를 넣으면 0또는 1 반환.
            return value;
        }
    }

    class Orc
    {
        public string name;
        public float height;
        public float weight;
        public int age;
        public char genderChar;
        public bool isResting;
        public void Smash()
        {
            string message = $"{name} (이)가 휘둘렀다!";
            Console.WriteLine(message);
        }
        public void Jump()
        {

            Console.WriteLine($"{name} (이)가 점프했다!");

        }



    }

}
