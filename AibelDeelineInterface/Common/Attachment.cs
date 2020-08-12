using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AibelDeelineInterface.Common
{
    public class Attachment
    {
        public Attachment(string fileName, string description, string extension, byte[] fileRaw, Communication owner = null)
        {
            FileName = fileName;
            Description = description;
            Extension = extension;
            InsertedOn = DateTime.Now;
            Owner = owner;
            Bytes = fileRaw;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FileName { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        [Required]
        [MaxLength(3)]
        public string Extension { get; set; }

        public DateTime InsertedOn { get; set; }

        public Communication Owner { get; set; }

        [Required]
        byte[] Bytes { get; set; }
    }
}
