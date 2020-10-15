using System;
using System.Collections.Generic;

namespace TestTask
{
    public class Checker : IStringHandler
    {
        /// <summary>
        /// Массив вариаций возможных скобок
        /// </summary>
        private Brackets[] ValidBrackets = new Brackets[]
        {
            new Brackets("(",")"),
            new Brackets("[","]"),
            new Brackets("{","}"),
        };
        private Stack<Brackets> useBrackets;

        public bool Check(string message)
        {
            try
            {
                useBrackets = new Stack<Brackets>();
                foreach (char c in message)
                {
                    foreach (Brackets brackets in ValidBrackets)
                    {
                        if (c == brackets.open[0]) OpenBracket(c);
                        else if (c == brackets.close[0]) CloseBracket(brackets);
                    }
                }
                return GetResult();
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Проверить закрытость всех скобок
        /// </summary>
        /// <returns>Результат проверки</returns>
        private bool GetResult()
        {
            return useBrackets.Count == 0;
        }

        /// <summary>
        /// Закрыть скобку
        /// </summary>
        /// <param name="bracket"></param>
        private void CloseBracket(Brackets bracket)
        {
            if (useBrackets.Peek().open == bracket.open)
            {
                useBrackets.Pop();
            }
            else throw new Exception();
        }
        /// <summary>
        /// Открыть скобку
        /// </summary>
        /// <param name="bracket"></param>
        private void OpenBracket(char bracket)
        {
            useBrackets.Push(new Brackets(bracket.ToString()));
        }
        /// <summary>
        /// 
        /// </summary>
        struct Brackets
        {
            public string open;
            public string close;

            public Brackets(string openBracket)
            {
                open = openBracket;
                close = null;
            }
            public Brackets(string openBracket,string closeBracket)
            {
                open = openBracket;
                close = closeBracket;
            }
        }
    }
}
