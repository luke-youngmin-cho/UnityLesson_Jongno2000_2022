using System;

namespace UnityLesson_CSharp_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 14;
            int b = 5;
            int c;

            float a_f = 14.0f;
            float b_f = 5.0f;
            float c_f;
            // 산술 연산
            // 덧셈, 뺄셈, 나눗셈, 곱셈, 나머지셈
            //========================================================

            // 덧셈
            c = a + b;
            c = FunctionForOperators.Sum(a,b);

            Console.WriteLine(c);
            // 뺄셈
            c = a - b;
            c = FunctionForOperators.Sub(a, b);
            Console.WriteLine(c);
            //나눗셈
            c = a / b; // 정수와 정수간의 연산 결과가 실수이면 소숫점은 버린다.
            Console.WriteLine(c);
            //곱셈
            c = a * b;
            Console.WriteLine(c);
            // 나머지셈
            c = a % b;
            Console.WriteLine(c); // 실수간연산을 해도 , 정수간의 연산으로 처리한다. 

            // 증감 연산
            // 증가 연산자, 감소 연산자
            //====================================================================
            Console.WriteLine($"Last C Value : {c}");
            // 증가연산자 : 1 을 증가시키는 연산자
            c++; // c = c + 1;
            Console.WriteLine(c);
            // 감소연산자 : 1 을 감소시키는 연산자 
            c--; // c = c - 1;
            Console.WriteLine(c);

            // 관계 연산
            // 결과값은 논리형 ( 참, 거짓 )
            //===================================================================
            
            // 같음 비교
            Console.WriteLine(a == b);
            // 다름 비교
            Console.WriteLine(a != b);
            // 큼 
            Console.WriteLine(a > b);
            // 크거나 같음
            Console.WriteLine(a >= b);
            // 작음
            Console.WriteLine(a < b);
            // 작거나 같음
            Console.WriteLine(a <= b);

            // 대입 연산 
            // 오른쪽 변수의 값을 왼쪽 변수에 (그냥, 더해서, 빼서, 나누어서, 곱해서, 나머지를 계산해서 )대입한다.
            Console.WriteLine($"Last C Value : {c}");
            // 더해서 대입
            c += a; // c = c + a;
            Console.WriteLine(c);
            // 빼서 대입
            c -= a; // c = c - a;
            Console.WriteLine(c);
            c += 50;
            Console.WriteLine($"Last C Value : {c}");
            // 나누어서 대입
            c /= a; // c = c / a;
            Console.WriteLine(c);
            // 곱해서 대입
            c *= a; // c = c * a;
            Console.WriteLine(c);
            // 나머지를 계산해서 대입
            c %= a; // c = c % a;
            Console.WriteLine(c);

            // 논리 연산
            // 피연산자(들)을 비교해서 연산 수행.
            // ===========================================================
            bool A = true;
            bool B = false;
            // OR
            // A 와 B 둘중에 하나라도 true 이면 true 반환, 나머지 경우에는 false 반환
            Console.WriteLine( A | B );
            // AND 
            // A 와 B 모두 true 이면 true 반환, 나머지 경우에는 false 반환
            Console.WriteLine(A & B);
            // NOT
            // A 의 값을 반전 . True 이면 False 로 , False 이면 True 로 반전시킴.
            Console.WriteLine(!A);
            // XOR
            // A 와 B 둘중에 하나만 true 일때 true 반환, 나머지 경우에는 false 반환
            Console.WriteLine(A ^ B);

            // 조건부 논리연산
            // 연산에 필요성에 대해서 판단을 한 후에 연산이 필요없으면 정해진 결과를 반환함.
            // 연산이 필요하면 연산후의 결과를 반환함.
            // 연산이 필요할때만 연산을 하기때문에 연산속도가 조금이나마 빠르다.
            //=============================================================================
            // 조건부 OR 연산
            Console.WriteLine(A || B);
            // 조건부 AND 연산
            Console.WriteLine(A && B);

            // 비트 연산
            // 비트 연산을 하는 이유 : 데이터를 효율적으로 관리하기 위함.
            // or 
            Console.WriteLine(a | b);
            // and 
            Console.WriteLine(a & b);
            // xor
            Console.WriteLine(a ^ b);
            // not
            Console.WriteLine(~a);

            a = 14;
            int howManyBitsYouWantToShift = 3;
            // shift - left 
            Console.WriteLine(a << howManyBitsYouWantToShift);
            // shift - right
            Console.WriteLine(a >> howManyBitsYouWantToShift);
            Console.WriteLine(FunctionForOperators.BitShiftRight(a, howManyBitsYouWantToShift));
            // FSM ( Finite State Machine , 유한 상태 머신 )
            // 클래스의 상태에따라 다른동작이나 조건을 특정해주기위해서 사용함. 
            // ex ) 플레이어의 상태를 FSM 에따라 나누고, 귀환이 가능한 조건을 FSM 의 특정상태
            // ( 피격중, 공격중 등등 ..) 에 구분해놓는다.
            // 그래서 사용자가 귀환을 눌렀는데 저런 특정상태( 피격중, 공격중 등등.. ) 이면
            // 귀환이 불가능하도록 코딩을 해놓는다. 
                        
        }
    }

    [Flags] // Bit- Shift 연산자의 예시 
    public enum e_FSM
    {
        아무것도안하는상태 = 0,
        피격당한상태 = 1 << 0,
        공격중인상태 = 1 << 1,
        점프중인상태 = 1 << 2,
        달리기중인상태 = 1 << 3,
    }
     
}
