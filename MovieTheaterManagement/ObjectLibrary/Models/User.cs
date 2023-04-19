using System;
using System.Collections.Generic;

#nullable disable

namespace ObjectLibrary.ObjectLibrary
{
    public partial class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public bool Role { get; set; }
    }
}
