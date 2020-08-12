using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AibelDeelineInterface.Common
{
    public class User
    {
        [Key]
        public string Id { get; set; }

        public LocationEnum Location { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email_Address { get; set; }

        public override bool Equals(object obj)
        {
            var asUser = obj as User;
            return asUser != null &&
                   asUser.Id == Id;
        }
    }
}
