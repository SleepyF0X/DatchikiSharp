using System.ComponentModel.DataAnnotations;

namespace DatchikiSharp.Core.Entitites
{
    public class Scaner
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        [Required]
        public string Name { get; set; }
        public string Desc { get; set; }
        public ScanerTypes Type { get; set; }
        public bool Status { get; set; }
        public bool Activity { get; set; }
    }

    public enum ScanerTypes
    {
        Movement = 1 ,
        Smoke = 2
    }
}
