using System;

namespace DatchikiSharp.Core.Events
{
    public class ScanerJsonEvent
    {
        public int Id { get; set; }
        public int ScanerId { get; set; }
        public bool Status { get; set; }
        public DateTime DateTime { get; set; }
    }
}
