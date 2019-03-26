
namespace TackandReport.DataServices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Globalization;


    internal sealed class Configuration : DbMigrationsConfiguration<TrackAndReportDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
            ContextKey = "TackandReport.DataServices.TrackAndReportDatabase";
        }
    }
}
