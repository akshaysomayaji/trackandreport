using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackAndReport.DataModels;
using TrackAndReport.DataModels.Core;

namespace TackandReport.DataServices.Interfaces
{
    /// <summary>
    /// IUserDetail DataService
    /// </summary>
    public interface IUserDetailDataService : IDataService, IDisposable
    {
        int CreateUserDetail(UserDetail UserDetail);
        UserDetail GetUserDetail(long id);
        int UpdateUserDetail(UserDetail UserDetail);
        int DeleteUserDetail(long id);
        List<UserDetail> UserDetailInquiry(string Name, DataGridPagingInformation paging, out TransactionalInformation transaction);
    }

    public interface IUserMembershipDataService : IDataService, IDisposable
    {
        int CreateUserMembership(UserMembership UserMembership);
        UserMembership Login(string userName, string password);
        UserMembership GetUserMembership(long id);
        UserMembership GetUserMembershipByEmail(string email);
        int UpdateUserMembership(UserMembership UserMembership);
        int DeleteUserMembership(long id);
        List<UserMembership> UserMembershipInquiry(string Name, DataGridPagingInformation paging, out TransactionalInformation transaction);
    }
}
