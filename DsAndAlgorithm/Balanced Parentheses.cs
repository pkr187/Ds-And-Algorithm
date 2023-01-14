using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsAndAlgorithm
{
    internal class BalancedParentheses
    {
        public void BalanceParantheses(string file)
        {
            string data = File.ReadAllText(file);
            string[] words = data.Split(" ");
            LinkedListStack<string> list = new LinkedListStack<string>();
            foreach (var item in words)
            {
                if (item.Contains("("))
                {
                    list.Push(item);
                }
                if (item.Contains(")"))
                {
                    list.Pop();
                }
            }
            list.Peek();
        }
    }
}

