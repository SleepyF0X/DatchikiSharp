using System;
using DatchikiSharp.Core.Entitites;

namespace DatchikiSharp.Core.Events
{
    public class SecurityEvent
    {
        public int ScanerId { get; set; }
        public Scaner Scaner { get; set; }
        public DateTime Time { get; set; }
        public SecurityEventTypes EventType { get; set; }
    }

    public enum SecurityEventTypes
    {
        Move = 1,
        Smoke = 2
    }
}
