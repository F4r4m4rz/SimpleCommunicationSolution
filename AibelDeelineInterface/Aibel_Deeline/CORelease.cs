using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AibelDeelineInterface.Common;

namespace AibelDeelineInterface.Aibel_Deeline
{
    public class CORelease : Communication
    {
        public CORelease() : base()
        {
            ControlObjectsList = new List<string>();
            TargetLocation = LocationEnum.Deeline;
        }

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

        public string ControlObjects { get; set; }

        public string Module { get; set; }

        public string Area { get; set; }

        public string Section { get; set; }

        public Hold Hold { get; set; }
    }
}
