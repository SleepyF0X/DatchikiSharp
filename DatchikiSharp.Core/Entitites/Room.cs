using System.Collections.Generic;

namespace DatchikiSharp.Core.Entitites
{
    public class Room
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int Size { get; set; }
        public RoomTypes Type { get; set; }
        public bool Status { get; set; }
        public List<Scaner> Scaners { get; set; }
    }

    public enum RoomTypes
    {
        Lecture,
        Laboratory
    }
}
