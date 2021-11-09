using System;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            string temp_string = "";
            for (int i = str.Length - 1; i > -1; i--){
                temp_string += str[i];}
            if (temp_string == str) return true; else return false;
	    }
                
    }
}
