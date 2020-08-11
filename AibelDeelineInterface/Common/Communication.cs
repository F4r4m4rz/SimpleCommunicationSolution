using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AibelDeelineInterface.Common
{
    public abstract class Communication
    {
        public User CreatedBy { get; }
        public DateTime CreatedOn { get; }
        public PriorityEnum PriorityLevel { get; }
        public User Responsible { get; }
        public StatusEnum Status { get; }

    }
}
