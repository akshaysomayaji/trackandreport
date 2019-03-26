using System.Data.Entity;
using TrackAndReport.DataModels.Core;
using TrackAndReport.DataModels.User;

namespace TackandReport.DataServices
{
    public class TrackAndReportDatabase : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserDetail> UserDetail { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserDetail>().ToTable("dbo.UserDetail");
        }
    }
}
