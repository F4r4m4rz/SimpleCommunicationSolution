using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AibelDeelineInterface.Common
{
    public abstract class Communication
    {
        protected Communication()
        {
            Status = StatusEnum.Open;
            Comments = new Conversation();
            Attachments = new List<Attachment>();
            CreatedOn = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        public LocationEnum OriginLocation { get; set; }

        [Required]
        public User CreatedBy { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public LocationEnum TargetLocation { get; set; }

        [Required]
        [MaxLength(50)]
        public string Purpose { get; set; }

        [Required]
        public PriorityEnum PriorityLevel { get; set; }

        public User Responsible { get; set; }

        [Required]
        public StatusEnum Status { get; set; }

        public Conversation Comments { get; set; }

        public ICollection<Attachment> Attachments { get; set; }

        public Hold Hold { get; set; }
    }
}
