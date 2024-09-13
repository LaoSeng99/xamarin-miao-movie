using System;
using System.Collections.Generic;
using System.Text;

namespace BXM308_Assignment.Model
{
    public class User
    {
        public string Id { get; set; } //For Relationship
        public string UserRefId { get; set; } //Firebase Key
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Image { get; set; }

    }
}
