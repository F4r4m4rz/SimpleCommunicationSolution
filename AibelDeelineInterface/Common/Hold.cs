using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace AibelDeelineInterface.Common
{
    public class Hold
    {
        public Hold()
        {
        }

        public int Id { get; set; }

        [Required]
        public User CreatedBy { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public StatusEnum Status { get; set; }

        public ICollection<Communication> Objects { get; set; }
    }
}
