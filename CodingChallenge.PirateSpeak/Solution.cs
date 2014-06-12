using System;
using System.Linq;

namespace CodingChallenge.PirateSpeak
{
    public class Solution
    {
        public string[] GetPossibleWords(string jumble, string[] dictionary)
        {
			//return all words where the sorted word exactly matches the sorted jumble
	        return (from word in dictionary
					where Sort(jumble) == Sort(word)
	                select word).ToArray();
        }

		/// <summary>
		/// Returns a new string with the characters of the input string
		/// sorted in ascending order
		/// </summary>
	    private string Sort(string input)
	    {
			return String.Concat(input.OrderBy(c => c));
	    }
    }
}