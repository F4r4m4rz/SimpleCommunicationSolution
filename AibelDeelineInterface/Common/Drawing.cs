using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AibelDeelineInterface.Common
{
    public class Drawing
    {
        private Drawing()
        {

        }

        public Drawing(string drawingNo, int revision)
        {
            if (string.IsNullOrWhiteSpace(drawingNo))
            {
                throw new ArgumentException("message", nameof(drawingNo));
            }

            if (revision < 1)
            {
                throw new ArgumentException("Revision should be a positive and not zero integer", nameof(drawingNo));
            }

            DrawingNo = drawingNo;
            Revision = revision;
        }

        [Key, Column(Order = 1)]
        public string DrawingNo { get; set; }

        [Key, Column(Order = 2)]
        public int Revision { get; set; }
    }
}
