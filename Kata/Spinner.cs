using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata
{
    /// <summary>
    /// Write a function that takes in a string of one or more words, and returns the same string, but with all five or more letter words reversed (Just like the name of this Kata).
    /// Strings passed in will consist of only letters and spaces. Spaces will be included only when more than one word is present.
    /// </summary>
    public class Spinner
    {
        public static string SpinWords(string sentence)
        {
            var splitter = sentence.Split(" ");
            var returnList = new List<string>();

            if (!String.IsNullOrWhiteSpace(sentence))
                try

                {
                    if (splitter.Length == 1 && splitter[0].Length < 5)
                        return Convert.ToString(splitter[0]);
                    else
                        foreach (string item in splitter)
                            if (item.Length >= 5)
                                returnList.Add(item);
                }
                catch (Exception) { throw; }

            return "s";
        }
    }
}
