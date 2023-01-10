using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsAndAlgorithm
{
    internal class BinarySearch
    {
        public void Search(string filePath)
        {
            string data = File.ReadAllText(filePath);
            string[] words = data.Split(",");
            Console.WriteLine(" Enter word to search");
            string search = Console.ReadLine();
            foreach (var word in words)
            {
                if (search.ToLower().Equals(word.ToLower()))
                {
                    Console.WriteLine("word found");
                    return;
                }
            }
            Console.WriteLine("word not found");
        }
    }
}