using System;

static class StringExtensions{
    public static bool IsPalindrome(this string str){
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        string reverseStr = new string(charArray);

        return str.Equals(reverseStr,StringComparison.OrdinalIgnoreCase);
    }
}

class Palindrome{
    static void Main(){
        string word = "level";
        bool isPalindrome = word.IsPalindrome();

        Console.WriteLine($"Is '{word}' a palindrome? {isPalindrome}");
    }
}