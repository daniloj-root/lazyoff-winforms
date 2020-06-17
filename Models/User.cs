using LazyOff.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyOff.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Number { get; set; }
        public string Password { get; set; }
        public UserStatus Status { get; set; }
        public UserType Type { get; set; }
        public DateTime BirthDate { get; set; }

        public User()
        {
            this.Status = UserStatus.ACTIVE;
        }
    }
}
