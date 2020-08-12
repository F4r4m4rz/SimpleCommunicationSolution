using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AibelDeelineInterface.Common
{
    public class ControlObject
    {
        private ControlObject()
        {

        }

        public ControlObject(string co)
        {
            if (string.IsNullOrWhiteSpace(co))
            {
                throw new ArgumentException("message", nameof(co));
            }

            Code = co;
        }

        [Key]
        public string Code { get; set; }
    }
}
