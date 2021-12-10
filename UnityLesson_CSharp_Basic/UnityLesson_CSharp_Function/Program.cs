using System;

namespace UnityLesson_CSharp_Function
{   
    class Program
    {
        static bool doPrintHelloWorld = true;
        static void Main(string[] args)
        {
            if (doPrintHelloWorld)
            {
                PrintHelloWorld();
            }

            string tmpSomething = "bla bla~~";
            bool tmpIsFinished = false;
            tmpIsFinished = PrintSomethingAndReturnIsFinished(tmpSomething);
            Console.WriteLine(tmpIsFinished);
        }

        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
        static void PrintSomething(string something)
        {
            Console.WriteLine(something);
        }
        static bool PrintSomethingAndReturnIsFinished(string something)
        {
            bool isFinished = false;
            Console.WriteLine(something);
            isFinished = true;
            return isFinished;
        }
    }
}
