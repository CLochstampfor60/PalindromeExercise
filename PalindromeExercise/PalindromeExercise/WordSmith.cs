using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string myWord)
        {
            if (myWord.SequenceEqual(myWord.Reverse()))
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


