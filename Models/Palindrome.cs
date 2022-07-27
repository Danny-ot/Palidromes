namespace Checker.Models
{
    public class PalindromeChecker
    {
        public static bool Check(string words)
        {
            char [] newChar =  words.ToCharArray();
            string reversedString = "";

            for(int i = newChar.Length-1 ; i > -1 ; i--)
            {
                reversedString += newChar[i];
            }
            return words == reversedString;
        }
    }
}