using System;
using System.Data.Entity;
using TackandReport.DataServices.Migrations;

namespace TackandReport.DataServices
{

    public interface IDataService
    {
        void CreateSession();
        void BeginTransaction();
        void CommitTransaction(Boolean closeSession);
        void RollbackTransaction(Boolean closeSession);
        void CloseSession();
    }

    public class DataServices : IDataService, IDisposable
    {
        TrackAndReportDatabase _connection;

        public TrackAndReportDatabase dbConnection
        {
            get { return _connection; }
        }


        public void CommitTransaction(Boolean closeSession)
        {
            dbConnection.SaveChanges();
        }

        public void RollbackTransaction(Boolean closeSession)
        {

        }

        public void Save(object entity) { }

        public void CreateSession()
        {

            try
            {
                Database.SetInitializer(new MigrateDatabaseToLatestVersion<TrackAndReportDatabase, Configuration>());

                _connection = new TrackAndReportDatabase();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException);
            }
        }
        public void BeginTransaction() { }

        public void CloseSession() { }

        public void Dispose()
        {
            if (_connection != null)
                _connection.Dispose();
        }
    }
}
