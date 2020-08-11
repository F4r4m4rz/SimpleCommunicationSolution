using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AibelDeelineInterface.Common
{
    public class Comment
    {
        public User CommentedBy { get; set; }
        public DateTime CommentedOn { get; set; }
        public Conversation Conversation { get; set; }
    }
}
