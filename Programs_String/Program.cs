using System;
using System.Text.RegularExpressions;

namespace Programs_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string textWithCountryNames = "Afghanistan,Ecuador,Albania,Italy,Algeria,Gabon,Andorra,Belgium,Angola,Antigua,Jamaica,Argentina,France,Armenia,Australia,Jordan,Austria,Barbados,Belarus";

            Regex regex = new Regex(@"\b[A]\w+");
            MatchCollection countryMatch = regex.Matches(textWithCountryNames);

            foreach (Match match in countryMatch)
            {
                Console.WriteLine("Country name : {0}, Index : {1}", match.Value, match.Index);
            }

        }
    }
}
