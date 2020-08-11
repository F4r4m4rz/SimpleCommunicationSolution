using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AibelDeelineInterface.Common
{
    public abstract class Conversation
    {
        public Communication Owner { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
