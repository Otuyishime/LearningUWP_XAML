using System;
using System.Collections.Generic;
using System.Text;

namespace LearningUWP_XAML.Models
{
    public class UserManager
    {
        public List<User> Users { get; set; }
        public User AddUser(User user)
        {
            if (user.GetType() == typeof(User))
            {
                Users.Add(user);
                return user;
            }
            return null;
        }
    }
}
