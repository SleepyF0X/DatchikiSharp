using System;
using DatchikiSharp.Core.Entitites;

namespace DatchikiSharp.Core.Events
{
    public class RoomEvent
    {
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public bool Status { get; set; }
        public DateTime Time { get; set; }
    }
}
