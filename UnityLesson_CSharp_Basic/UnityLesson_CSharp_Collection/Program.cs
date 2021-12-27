using System;
using System.Collections.Generic; // generic collections 을 쓰기위해 필요한 namespace
// Collection
// 동적 배열 이라고도함 
// Array 와 다르게 크기를 정해놓지않고
// Collection 단어 뜻대로 수집하듯이
// 아이템들을 추가하거나 뺄수 있으며, 그에따라 데이터가 유동적으로 변한다.
namespace UnityLesson_CSharp_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //===============================================
            // List
            //===============================================
            List<int> _list = new List<int>();
            _list.Add(3);
            _list.Add(2);
            _list.Add(1);
            _list.Add(0);
            _list.Add(3);

            // remove
            // 0 번째 인덱스부터 탐색하고, 첫번째로 인자와 같은 요소를 발견하면 삭제.
            // 삭제 성공시 true 반환, 인자와 같은 요소를 찾지 못하면 false 를 반환.
            _list.Remove(3);

            int length = _list.Count;
            for (int i = 0; i < length; i++)
            {
                int tmpNumber = _list[i];
                Console.WriteLine(tmpNumber);
            }

            // foreach 는 collection 이 가지고있는 타입의 아이템 만큼 반복문을 실행하면서 각 아이템을 반환한다.
            foreach (int num in _list)
            {
                Console.WriteLine(num);
                // foreach 가 처음 돌때는 num 에 _list[0] 반환 
                // 두번째 돌때는 num 에 _list[1] 반환 ...
            }

            //==============================================
            // Dictionary
            //==============================================
            Dictionary<string, string> _dic = new Dictionary<string, string>();
            _dic.Add("검사", "양손대검을 사용하여 물리공격을 하는 클래스");
            _dic.Add("마법사", "지팡이를 사용하여 마법공격을 하는 클래스");
            _dic.Add("수호자", "창과 방패를 사용하여 물리공격 및 방어 위주의 클래스");

            //_dic.Remove("검사");
            bool isSwordMaster = _dic.ContainsKey("검사");
            if (isSwordMaster)
            {
                string tmpValue = _dic["검사"];
                Console.WriteLine($"검사 : {tmpValue}");
            }
            else
            {
                Console.WriteLine("검사를 찾을 수 없습니다");
            }

            // Dictionary 도 foreach 구문이 가능하다.
            // dictionary 도 collection 이고
            // dictionary 의 key 도 collection 이고
            // dictionary 의 value 도 collection 이다.
            // 즉, 위 세가지 모두 foreach 구문이가능하다.
            foreach (string sub in _dic.Keys)
            {
                string tmpValue = _dic[sub];
                Console.WriteLine($"{sub} : {tmpValue}");
            }
            foreach (string sub in _dic.Values)
            {
                Console.WriteLine(sub);
            }
            foreach (KeyValuePair<string,string> sub in _dic)
            {
                string tmpKey = sub.Key;
                string tmpValue = sub.Value;
                Console.WriteLine($"{tmpKey}:{tmpValue}");
            }
            // 위 세가지 경우가 있지만,  
            // dictionary 는 단어 뜻대로 사전 처럼 사용하기 위한 collection 이다. 
            // 우리가 사전을 찾을때 ,  
            // 단어를 먼저 찾고 거기에 따라 단어의 뜻을 찾는다.  
            // dictionary 에서 key 는 단어, value 는 단어의 뜻과 같은 역할이다. 
            // 따라서 foreach 문을 사용해서 접근할때도, 
            // dictionary 의 key 로 반복문을 통해 접근하는 경우가 대부분이지,  
            // value 나 dictionary 자체로 접근하는 경우는 잘 없다.  
            // 마치 '사과' 라는 단어를 검색하면 '사과나무에서 열리는 열매' 라는 뜻을 찾는것이지
            // '사과나무에서 열리는 열매' 를 검색해서 '사과'를 찾거나 
            // '사과 : 사과나무에서 열리는 열매' 자체를 검색하지 않는것과 같다고 생각하면 된다.  

            //==============================================================
            //Queue ( List 와 비슷하나 FIFO (First Input First Output)
            //==============================================================
            Queue<int> _queue = new Queue<int>();

            _queue.Enqueue(10);
            _queue.Enqueue(20);
            _queue.Enqueue(30);

            Console.WriteLine(_queue.Peek()); // 가장 첫번째에 있는 값을 리턴
            Console.WriteLine(_queue.Dequeue()); // 가장 첫번째에 있는 값을 Queue에서 빼고 리턴
            Console.WriteLine(_queue.Dequeue());
            Console.WriteLine(_queue.Dequeue());

            //==============================================================
            //Stack ( List 와 비슷하나 LIFO (Last Input First Output)
            //==============================================================
            Stack<int> _stack = new Stack<int>();

            _stack.Push(10);
            _stack.Push(20);
            _stack.Push(30);

            Console.WriteLine(_stack.Peek()); // 가장 마지막에 있는 값을 리턴
            Console.WriteLine(_stack.Pop()); // 가장 마지막에 있는 값을 Stack 에서 빼고 리턴
            Console.WriteLine(_stack.Pop());
            Console.WriteLine(_stack.Pop());

        }
    }
}
