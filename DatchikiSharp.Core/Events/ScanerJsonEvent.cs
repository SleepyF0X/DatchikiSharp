using DatchikiSharp.Core.Entitites;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatchikiSharp.Core.Events
{
    public class ScanerJsonEvent
    {
        public int Id { get; set; }
        [ForeignKey("Scaner")]
        public int ScanerId { get; set; }
        public Scaner Scaner { get; set; }
        public bool Status { get; set; }
        public DateTime DateTime { get; set; }
    }
}
