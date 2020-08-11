using System;
using System.ComponentModel.DataAnnotations;
using AibelDeelineInterface.Common;

namespace AibelDeelineInterface.Deeline_Aibel
{
    public class UdaMacro
    {
        public UdaMacro(string fileName, byte[] fileRaw)
        {
            CreatedOn = DateTime.Now;
            IsCapturedByAibel = false;
            Macro = new Attachment(fileName, description: "UDA Macro", "XML", fileRaw);
        }

        [Key]
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsCapturedByAibel { get; set; }

        [Required]
        public Attachment Macro { get; set; }
    }
}
