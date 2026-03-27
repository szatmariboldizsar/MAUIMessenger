using System;
using System.Collections.Generic;
using System.Text;

namespace messaging_assignment.DAL.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
    }
}
