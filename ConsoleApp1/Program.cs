using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Program
    {
        public  string[] CheckforDuplicates(List<string> originalList)
        {
            var duplicates = originalList
             .GroupBy(p => p)
             .Where(g => g.Count() > 1)
             .Select(g => g.Key);

            return duplicates.ToArray();
        }


        static void Main(string[] args)
        {
            
        }
    }
}

