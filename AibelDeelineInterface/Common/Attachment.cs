using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AibelDeelineInterface.Common
{
    public abstract class Attachment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Extension { get; set; }
        public DateTime InsertedOn { get; set; }
        public Communication Owner { get; set; }
        byte[] Bytes { get; set; }
    }
}
