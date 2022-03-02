using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class Helper
    {

        public static User[] AddToArray(User[] users, User user )
        {
            Array.Resize(ref users , users.Length + 1);
            users[users.Length - 1] = user; 
            return users;
        }
        public static User FindUser(User[] users, int id)
        {
            User myObj = new User();
            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    myObj = user;                    
                }
            }
            return myObj;    
        }

        public static string ShowUsers(User[] users)
        {
            string myObj= "";
            foreach (var user in users)
            {
                myObj=  $"Name: {user.Name}\nSurname: {user.Surname}\nUsername: {user.Username}\nPassword: {user.Password}\nId: {user.Id}";
            }
            return myObj; 
        }
    }
}
