using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TackandReport.DataServices.Interfaces;
using TrackAndReport.DataModels;
using TrackAndReport.DataModels.Core;

namespace TackandReport.DataServices.Components
{
    public class UserDetailDataService : DataServices, IUserDetailDataService
    {
        public int CreateUserDetail(UserDetail UserDetail)
        {
            throw new NotImplementedException();
        }

        public int DeleteUserDetail(long id)
        {
            throw new NotImplementedException();
        }

        public UserDetail GetUserDetail(long id)
        {
            UserDetail UserDetail = dbConnection.UserDetail.SingleOrDefault(o => o.Id == id);
            return UserDetail;
        }

        public int UpdateUserDetail(UserDetail UserDetail)
        {
            throw new NotImplementedException();
        }

        public List<UserDetail> UserDetailInquiry(string Name, DataGridPagingInformation paging, out TransactionalInformation transaction)
        {
            throw new NotImplementedException();
        }
    }
}
