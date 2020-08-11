using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AibelDeelineInterface.Common
{
    public class User
    {
        public string Id { get; set; }
        public LocationEnum Location { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Email_Address { get; set; }
        public Responsibility Responsibility { get; set; }
    }
}
