using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AibelDeelineInterface.Common;

namespace AibelDeelineInterface.Aibel_Deeline
{
    public class CORelease : Communication
    {
        private CORelease() : base()
        {
            ControlObjects = new List<ControlObject>();
            TargetLocation = LocationEnum.Deeline;
            Purpose = "Releasing COs to Deeline";
        }

        public CORelease(User creator, LocationEnum origin, string module = null, string area = null, string section = null) : this()
        {
            CreatedBy = creator;
            OriginLocation = origin;
            Module = module;
            Area = area;
            Section = section;
        }

        public CORelease(User creator, LocationEnum origin, PriorityEnum priority, string module = null, string area = null, string section = null)
            : this(creator, origin, module, area, section)
        {
            PriorityLevel = priority;
        }

        public CORelease(User creator, LocationEnum origin, PriorityEnum priority, params string[] controlobjects) : this(creator, origin, priority)
        {
            foreach (var co in controlobjects)
            {
                ControlObjects.Add(new ControlObject(co));
            }
        }

        public CORelease(User creator, LocationEnum origin, params string[] controlobjects) : this(creator, origin, PriorityEnum.Normal, controlobjects)
        {

        }

        public ICollection<ControlObject> ControlObjects { get; set; }

        public string Module { get; set; }

        public string Area { get; set; }

        public string Section { get; set; }
    }
}
