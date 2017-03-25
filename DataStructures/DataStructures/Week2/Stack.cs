using System;
using System.Linq;
using DataStructures.List;
using DataStructures.Structures;

namespace DataStructures.Week2
{
    public class Stack : IRunner
    {
        public void Run()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.Write(stack);
            Console.WriteLine(CheckBrackets("()()(())"));
            Console.WriteLine(CheckBrackets("()()(())"));
            Console.WriteLine(CheckBrackets("[][()()]"));
        }

        public bool CheckBrackets(String brackets)
        {
            char open1 = '(';
            char open2 = '{';

            char closes1 = ')';
            char closes2 = ']';

            IStack<char> bracketStack = new Stack<char>();
            foreach (var bracket in brackets.ToCharArray())
            {
                if (bracket == open1 || bracket == open2)
                {
                    bracketStack.Push(bracket);
                }
                if (bracket == closes1 || bracket == closes2)
                {
                    bracketStack.Pop();
                }
            }
            return bracketStack.Empty();
        }
    }
}