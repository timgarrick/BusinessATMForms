using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessATMForms
{
    internal class UserService
    {
        public static List<User> userList = new List<User>();

        internal static User createUser(TextBox usernameInput, TextBox passwordInput)
        {
            User newUser = new User(1,usernameInput.Text, passwordInput.Text, "test@test.com");
            userList.Add(newUser);
            return newUser;
        }

        internal static bool login(TextBox usernameInput, TextBox passwordInput)
        {
            foreach (User user in userList)
            {
                if(user.Name.Equals(usernameInput.Text)) 
                {
                    if(user.Password.Equals(passwordInput.Text))
                    {
                        passwordInput.Text = "Correct password";
                    } else
                    {
                        passwordInput.Text = "Incorrect password";
                    }
                }
            }

            return false;

        }

    }
}
