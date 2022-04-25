using System;
using System.Text.RegularExpressions;

namespace Programs_String
{
    class Program
    {
        //find missing integer in an array
        static int arraySum;
        int mean = 9;
        public int MissingIntegerInArray() 
        {
            int[] array = { 2, 4, 20 };

            for(int item =0; item < array.Length; item++)
            {
                arraySum += array[item];
                //Console.WriteLine(arraySum);
            }
            int missingElement =(9*4) - arraySum;
            //Console.WriteLine(missingElement);
            return missingElement;
        }


        static void Main(string[] args)
        {
            string textWithCountryNames = "Afghanistan,Ecuador,Albania,Italy,Algeria,Gabon,Andorra,Belgium,Angola,Antigua,Jamaica,Argentina,France,Armenia,Australia,Jordan,Austria,Barbados,Belarus";

            Regex regexA = new Regex(@"\b[A]\w+");
            Regex regexI = new Regex(@"\b[I]\w+");
            MatchCollection countryMatch = regexI.Matches(textWithCountryNames);

            foreach (Match match in countryMatch)
            {
                Console.WriteLine("Country name : {0}, Index : {1}", match.Value, match.Index);
            }
            Program test = new Program();
            Console.WriteLine(test.MissingIntegerInArray());

        }
    }
}
