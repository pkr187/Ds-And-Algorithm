using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsAndAlgorithm
{
    internal class Anagram
    {
        public void AnagramWord(string firstInput, string lastInput)
        {
            char[] firstArr = firstInput.ToCharArray();
            Array.Sort(firstArr);
            char[] lastArr = lastInput.ToCharArray();
            Array.Sort(lastArr);
            if (firstArr.Length.Equals(lastArr.Length))
            {
                for (int i = 0; i < firstArr.Length; i++)
                {
                    if (!firstArr[i].Equals(lastArr[i]))
                    {
                        Console.WriteLine("Not an Anagram");
                        return;
                    }
                }
                Console.WriteLine("Given Word is an Anagram");
            }
            else
            {
                Console.WriteLine("Given Word is not an Anagram");
            }
            firstInput = firstArr.ToString();
            lastInput = lastArr.ToString();
        }
    }
}