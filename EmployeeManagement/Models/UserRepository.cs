using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Models
{
    public class UserRepository
    {
        public static List<User> users = new List<User>();

        public static void create(User user)
        {
            users.Add(user);
        }
        public static void delete(int id)
        {
            User? selectedUser = users.Where(x => x.Id == id).FirstOrDefault();
            if (selectedUser != null)
            {
                users.Remove(selectedUser);
            }
        }
        public static void update(User User, int id)
        {
            User? selectedUser = users.Where(x => x.Id == id).FirstOrDefault();
            if (selectedUser != null)
            {
                selectedUser.Name = User.Name;
                selectedUser.Age = User.Age;
                selectedUser.Email = User.Email;
                selectedUser.Password = User.Password;
            }
        }
    }
}
