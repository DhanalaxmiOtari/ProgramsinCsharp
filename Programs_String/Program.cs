﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Programs_String
{
    class Program
    {
        #region
        //Duplicate char in the string
        public int CountDuplicateOccuranceElementInArray()
        {
            string myString = "passage";
            char[] myChar = myString.ToCharArray();


            int count = 0;
            for (int i = 0; i < myString.Length; i++)
            {
                for (int j = 1; j < myString.Length; j++)
                {
                    count = 0;
                    if (myChar[i] == myChar[j])
                    {
                        ++count;

                    }
                }

            }

            return count;

        }
        #endregion
        public void CountDuplicateElementInArray()
        {
            List<int> elements = new List<int> { 1, 2, 4, 8, -1, 0, 2, 4, 9, 0 };
            IEnumerable<int> duplicateItems = elements.GroupBy(x => x).Where(g => g.Count() > 1).Select(x => x.Key);
            Console.WriteLine("Duplicates : " + String.Join(",", duplicateItems));
        }
        public void CountDuplicateNames()
        {
            List<string> names = new List<string> { "Dhanu", "Gautu", "Uma", "Shireen", "Jehan", "Uma", "Shireen", "Jehan" };
            IEnumerable<string> DuplicateNames = names.GroupBy(x => x).Where(g => g.Count() > 1).Select(x => x.Key);
            Console.WriteLine("Duplicate names : " + String.Join(",", DuplicateNames));
        }
        public void CountUniqueElements()
        {
            var listA = new[] { "A", "B", "C", "D", "B", "E", "C", "F", "G" };
            var listB = new[] { "A", "B", "C", "E" };
            var listC = listB.Where(x => listA.Where(y => y == x).Count() == 1);
            foreach (var item in listC) Console.WriteLine(item);
        }
        //find missing integer in an array
        static int arraySum;
        int mean = 9;
        public int MissingIntegerInArray()
        {
            int[] array = { 2, 4, 20 };

            for (int item = 0; item < array.Length; item++)
            {
                arraySum += array[item];
                //Console.WriteLine(arraySum);
            }
            int missingElement = (9 * 4) - arraySum;
            //Console.WriteLine(missingElement);
            return missingElement;
        }
        // print numbers without loop
        public static void PrintNumbers()
        {
            try
            {
                int i = 0;
            begine:
                i = i + 1;
                if (i < 20)
                {
                    Console.WriteLine(i);
                    goto begine;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        static void Main(string[] args)
        {
            /*string textWithCountryNames = "Afghanistan,Ecuador,Albania,Italy,Algeria,Gabon,Andorra,Belgium,Angola,Antigua,Jamaica,Argentina,France,Armenia,Australia,Jordan,Austria,Barbados,Belarus";

            Regex regexA = new Regex(@"\b[A]\w+");
            Regex regexI = new Regex(@"\b[I]\w+");
            MatchCollection countryMatch = regexI.Matches(textWithCountryNames);

            foreach (Match match in countryMatch)
            {
                Console.WriteLine("Country name : {0}, Index : {1}", match.Value, match.Index);
            }*/
            Program test = new Program();
            //Console.WriteLine(test.MissingIntegerInArray());
            //Program.PrintNumbers();
            test.CountDuplicateElementInArray();
            test.CountDuplicateNames();
            test.CountUniqueElements();
        }
    }
}
