using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AibelDeelineInterface.Common
{
    public class Comment
    {
        [Key]
        [Column(Order = 1)]
        public User CommentedBy { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime CommentedOn { get; set; }

        [Key]
        [Column(Order = 3)]
        public Conversation Conversation { get; set; }
    }
}
