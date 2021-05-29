namespace DatchikiSharp.Core.Entitites
{
    public class Room
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int Size { get; set; }
        public RoomTypes Type { get; set; }
    }

    public enum RoomTypes
    {
        Lecture,
        Laboratory
    }
}
