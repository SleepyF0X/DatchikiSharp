namespace DatchikiSharp.Core.Entitites
{
    public class Scaner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public ScanerTypes Type { get; set; }
    }

    public enum ScanerTypes
    {
        Movement,
        Smoke
    }
}
