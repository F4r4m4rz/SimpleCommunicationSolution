using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AibelDeelineInterface.Common;

namespace AibelDeelineInterface.Deeline_Aibel
{
    public class ModelUpdateRequest : Communication
    {
        public ModelUpdateRequest()
        {
        }

        [Key]
        public int Id { get; set; }

        [Required]
        //TODO: Think of a drag and drap picture and represent into html
        public string Reason { get; set; }

        public string ControlObjects { get; set; }

        [NotMapped]
        public IEnumerable<string> ControlObjectsList
        {
            get
            {
                return ControlObjects.Split(';');
            }

            set
            {
                ControlObjects = string.Empty;
                foreach (var item in value)
                {
                    ControlObjects = string.IsNullOrEmpty(ControlObjects) ? $"{item}" : $"{ControlObjects};{item}";
                }
            }
        }
    }
}
