using System;
using System.Text.RegularExpressions;

/* 
Get every palindrome in a string, place them in a list and return. Additionally identify the largest palindrome and the shortest.
Return the total number of palindromes.
*/

namespace Palindrome
{
    public class Palindrome
    {
        //Recursively checks whether a section of a string is a Palindrome. Returns true if it is.
        public static bool IsPalindrome(string word, int start, int end)
        {
            if(end - start == 0 || end - start == 1 && word[start] == word[end]){
                return true;
            }
            else if (word[start] == word[end])
            {
                start++;
                end--;
                return IsPalindrome(word, start, end);
            }
            else
            {
                return false;
            }
        }
        public static List<string> GetAllPalindromes(string inputString)
        {
            List<string> allPalindromes = new List<string>();
            inputString = SanatizeInput(inputString);
            for(int x = 0; x < inputString.Length-1; x++)
            {
                for (int y = inputString.Length-1; y > x; y--)
                {
                    if (IsPalindrome(inputString, x, y))
                    {
                        allPalindromes.Add(inputString.Substring(x, y-x+1));
                    }
                }
                
            }
            return allPalindromes;
        }

        //Removes Numbers and Special Characters.
        public static string SanatizeInput(string inputString)
        {
            inputString = inputString.ToLower();
            string charactersToBeRemoved = "[^a-zA-Z]";
            inputString = Regex.Replace(inputString, charactersToBeRemoved, "");
            return inputString;
        }

    }
}