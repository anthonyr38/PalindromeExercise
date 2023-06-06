using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word) 
        {
            //throw new NotImplementedException();
            var revWord = "";
            for(int revd = word.Length-1; revd >= 0; revd--)
            {
                revWord += word[revd];
            }
           
            if (word.ToLower() == revWord.ToLower()) 
            {
                return true;
            }
            else 
            {
                return false; 
            }

        }
    }
}
