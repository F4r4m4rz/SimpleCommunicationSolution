using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AibelDeelineInterface.Common
{
    public class Conversation
    {
        [Key]
        public Communication Owner { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
