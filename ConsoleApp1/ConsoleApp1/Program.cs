using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            UserOperation operation1 = new UserOperation();           
            UserOperation operation2 = new UserOperation();
            UserOperation operation3 = new UserOperation();
            UserOperation operation4 = new UserOperation();
            UserOperation operation5 = new UserOperation();
            
            operation1.CreateAccount("Fakhri", "Afandiyev", "Fakhri-P127", "salam123");                           
            operation2.CreateAccount("Ali", "Afandiyev", "Fakhri-P127", "salam123");
            operation3.CreateAccount("Ismayil", "Afandiyev", "Fakhri-P127", "salam123");
            operation4.CreateAccount("Parvin", "Afandiyev", "Fakhri-P127", "salam123");
            operation5.CreateAccount("Cahangir", "Afandiyev", "Fakhri-P127", "salam123");

            if (User.count==3)
            {

            }
        }
    }
}