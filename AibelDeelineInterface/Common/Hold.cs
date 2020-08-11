using System;
using System.ComponentModel.DataAnnotations;

namespace AibelDeelineInterface.Common
{
    public class Hold
    {
        public Hold()
        {
        }

        [Required]
        public User CreatedBy { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Key]
        public Communication Object { get; set; }

        public StatusEnum Status { get; set; }
    }
}
