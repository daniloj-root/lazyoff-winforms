using LazyOff.Enums;
using LazyOff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LazyOff.Repositories
{
    public class UserRepository
    {
        private List<User> users { get; set; }

        public UserRepository()
        {
            users = new List<User>();
            users.Add(new User
            {
                ID = GetPrimaryKey(),
                Name = "Erik",
                Surname = "Vitelli",
                Username = "evitelli",
                Password = FormTools.To256Hash("1234"),
                Type = UserType.ADMIN,
            });

            users.Add(new User
            {
                ID = GetPrimaryKey(),
                Name = "Marcelo",
                Surname = "Fulaninho",
                Address = "Rua dos Bobos",
                Number = "0",
                Username = "Marcelinho",
                Password = FormTools.To256Hash("1234"),
                Type = UserType.ADMIN
            });
        }

        public IEnumerable<User> Get()
        {
            return users.Where(x => x.Status == UserStatus.ACTIVE);
        }

        public User GetById(int ID)
        {
            return users.First(x => x.ID == ID && x.Status == UserStatus.ACTIVE);
        }

        public void Add(User user)
        {
            users.Add(user);
        }
         
        public void Update(User updatedUser)
        {
            var user = users.ElementAt(updatedUser.ID - 1);
            var index = users.IndexOf(user);
            users[index] = updatedUser;
        }

        public void Delete(User user)
        {
            user.Username = string.Empty;
            user.Name = string.Empty;
            user.Surname = string.Empty;
            user.Address = string.Empty;
            user.Number = string.Empty;
            user.Password = string.Empty;
            user.Status = UserStatus.INACTIVE;

            this.Update(user);
        }

        public bool UserExists(User user)
        {
            if (users.Find(x => x.Username.Equals(user.Username) && x.Password.Equals(user.Password) && x.ID.Equals(user.ID)) != null)
                return true;

            return false;
        }

        // get next list's id 
        public int GetPrimaryKey()
        {
            return users.Count + 1;
        }
    }
}
