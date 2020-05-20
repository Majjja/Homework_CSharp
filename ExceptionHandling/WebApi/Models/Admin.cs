using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<User> Friends { get; set; }

        public int GetAdminId()
        {
            return Id;
        }
    }
}
