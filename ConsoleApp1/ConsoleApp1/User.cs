using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class User
    {
        public string Name;
        public string Surname;
        public string Username;
        public string Password;
        public int Id;
        public static int count;


        public User()
        {
            count++;
            Id = count;
        }

        public void ToString()
        {
          
        }
    }
}
