using System;

public class Answer
{
    static bool IsPalindrome(int number){
   if (number < 10000 || number > 99999)
   {
     Console.WriteLine("Число не пятизначное");
     return false;
   }
      
      int originalNumber = number;
      int reversedNumber = 0;
      
      while (number > 0)
      {
        int digit = number % 10;
        reversedNumber = reversedNumber * 10 + digit;
        number/= 10;
      }
       return originalNumber == reversedNumber;
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
            number = 14212;
            number = 234322;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}