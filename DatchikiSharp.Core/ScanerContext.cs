using DatchikiSharp.Core.Entitites;
using DatchikiSharp.Core.Events;
using Microsoft.EntityFrameworkCore;

namespace DatchikiSharp.Core
{
    public class ScanerContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Scaner> Scaners { get; set; }
        public DbSet<RoomEvent> RoomEvents { get; set; }
        public DbSet<ScanerJsonEvent> ScanerEvents { get; set; }
        public ScanerContext(DbContextOptions<ScanerContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<RoomEvent>().HasKey(re => re.RoomId);
        }
    }
}
