using System;
using AibelDeelineInterface.Common;

namespace AibelDeelineInterface.Deeline_Aibel
{
    public class DrawingExport
    {
        public DrawingExport(string fileName, byte[] pdfRaw, byte[] dwgRaw)
        {
            CreatedOn = DateTime.Now;
            IsCapturedByAibel = false;
            PDF = new Attachment(fileName, "Drawing - PDF", "PDF", pdfRaw);
            DWG = new Attachment(fileName, "Drawing - DWG", "DWG", dwgRaw);
        }

        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsCapturedByAibel { get; set; }
        public Attachment PDF { get; set; }
        public Attachment DWG { get; set; }
    }
}
