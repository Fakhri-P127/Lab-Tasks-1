using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class UserOperation:IAccount
    {
        User[] Users = { };
        
        //public UserOperation(object operation)
        //{
        //    operation = operation;
        //}
        public void CreateAccount(string name, string surname, string username, string password)
        {
            
                Console.WriteLine($"{name} {surname} {username} {password} ");
            
        }
    }
}
