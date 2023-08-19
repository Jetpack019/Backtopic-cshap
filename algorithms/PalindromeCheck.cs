using System;
class PalindromeCheck{
   static void Main(string[] args){
        string str = "radar";
        bool isPalindrome = IsPalindrome(str);

        if(isPalindrome){
            Console.WriteLine(str + " is a palindrome,");
        }else{
            Console.WriteLine(str + " is not a palindrome.");
        }

   
    }
    static bool IsPalindrome(string str){
            int left = 0;
            int right = str.Length - 1;

        while (left < right) {
            if (str[left] != str[right]) {
                return false;
            }
                left++;
                right--;
            }
            return true;
        }

}