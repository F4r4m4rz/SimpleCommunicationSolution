using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AibelDeelineInterface.Aibel_Deeline;
using AibelDeelineInterface.Common;

namespace AibelDeelineInterface.Deeline_Aibel
{
    public class ModelUpdateRequest : Communication
    {
        public ModelUpdateRequest()
        {
            ControlObjects = new List<ControlObject>();
        }

        [Required]
        //TODO: Think of a drag and drap picture and represent into html
        public string Reason { get; set; }

        public List<ControlObject> ControlObjects { get; set; }
    }
}
