using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLesson_CSharp_Operator
{
    class FunctionForOperators
    {
        // 산술 연산
        // 덧셈
        static public int Sum(int a, int b)
        {
            return a + b;
        }
        // 뺄셈
        static public int Sub(int a, int b)
        {
            return a - b;
        }
        // 나눗셈
        static public int Div(int a, int b)
        {
            return a / b;
        }

        // 곱셈
        static public int Mul(int a , int b)
        {
            return a * b;
        }
        // 나머지셈
        static public int Mod(int a, int b)
        {
            return a % b;
        }
        
        // 증감연산
        //====================================================================
        static public int Increase(int a)
        {
            return a++;
        }
        static public int Decrease(int a)
        {
            return a--;
        }

        // 관계연산
        //====================================================================
        // 같은가?
        static public bool IsSame(int a, int b)
        {
            return a == b;
        }
        static public bool IsDifferent(int a, int b)
        {
            return a != b;
        }
        static public bool IsBigger(int a, int b)
        {
            return a > b;
        }
        static public bool IsBiggerOrSame(int a, int b)
        {
            return a >= b;
        }
        static public bool IsSmaller(int a, int b)
        {
            return a < b;
        }
        static public bool IsSmallerOrSame(int a, int b)
        {
            return a <= b;
        }

        // 대입연산
        //=================================================================
        static public int PlusBToA(int a, int b)
        {
            return a += b;
        }
        static public int MinusBToA(int a, int b)
        {
            return a -= b;
        }
        static public int DivBToA(int a , int b)
        {
            return a /= b;
        }
        static public int MulBToA(int a, int b)
        {
            return a *=b;
        }
        static public int ModBToA(int a, int b)
        {
            return a %= b;
        }
        
        // 논리 연산
        //==================================================================
        static public bool LogicOR(bool a, bool b)
        {
            return a | b;
        }
        static public bool LogicAND(bool a, bool b)
        {
            return a & b;
        }
        static public bool LogicNOT(bool a)
        {
            return !a;
        }
        static public bool LogicXOR(bool a, bool b)
        {
            return a ^ b;
        }

        // 조건부 논리연산
        //============================================
        static public bool ConditionalLogicOR(bool a, bool b)
        {
            return a || b;
        }
        static public bool ConditionalLogicAND(bool a, bool b)
        {
            return a && b;
        }

        // 비트연산
        //===================================================
        static public int BitLogicOR(int a, int b)
        {
            return a | b;
        }
        static public int BitLogicAND(int a, int b)
        {
            return a & b;
        }
        static public int BitLogicNOT(int a)
        {
            return ~a;
        }
        static public int BitLogicXOR(int a, int b)
        {
            return a ^ b;
        }

        static public int BitShiftLeft(int a, int howManyBitsYouWantToShift)
        {
            return a << howManyBitsYouWantToShift;
        }
        static public int BitShiftRight(int a, int howManyBitsYouWantToShift)
        {
            return a >> howManyBitsYouWantToShift;
        }
    }
}
