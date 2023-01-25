using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "#?!";
      int score = 0;


      Console.WriteLine("Please enter a password: ");
      string password = Console.ReadLine();

      if(password.Length >= minLength){
        score++;
      }
      if(Tools.Contains(password, uppercase)){
        score++;
      }
      if(Tools.Contains(password, lowercase)){
        score++;
      }
      if(Tools.Contains(password, digits)){
        score++;
      }
      if(Tools.Contains(password, specialChars)){
        score++;
      }

      switch (score){
        case 1:
          Console.WriteLine("Password is weak.");
          break;
        case 2:
          Console.WriteLine("Password is medium.");
          break;
        case 3:
          Console.WriteLine("Password is strong.");
          break;
        case 4:
          Console.WriteLine("Password is extremely strong.");
          break;
        case 5:
          Console.WriteLine("Password is extremely strong.");
          break;
        default:
          Console.WriteLine("Password doesn't meet any of the standards.");
          break;
      }
    }
  }
}
