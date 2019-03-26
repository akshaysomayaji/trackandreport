using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TackandReport.DataServices.Components;
using TackandReport.DataServices.Interfaces;
using TrackAndReport.DataModels;
using TrackAndReport.DataModels.Core;

namespace TrackAndReport.BusinessServices.BusinessService
{
    public class UserDetailBusinessService
    {
        IUserDetailDataService _UserDetailDataService;

        private IUserDetailDataService UserDetailDataService
        {
            get { return _UserDetailDataService; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public UserDetailBusinessService()
        {
            _UserDetailDataService = new UserDetailDataService();
        }


        /// <summary>
        /// Get UserDetail
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public UserDetail GetUserDetail(long Id, out TransactionalInformation transaction)
        {
            transaction = new TransactionalInformation();

            UserDetail UserDetail = new UserDetail();
            try
            {

                UserDetailDataService.CreateSession();
                UserDetail = UserDetailDataService.GetUserDetail(Id);

                if (UserDetail != null)
                {
                    transaction.ReturnStatus = true;
                }
                else
                {
                    transaction.ReturnStatus = false;
                    transaction.ReturnMessage.Add("User Detail id not found.");
                }
            }
            catch (Exception ex)
            {
                transaction.ReturnMessage = new List<string>();
                string errorMessage = ex.Message;
                transaction.ReturnStatus = false;
                transaction.ReturnMessage.Add(errorMessage);
            }
            finally
            {
                UserDetailDataService.CloseSession();
            }

            return UserDetail;

        }

    }
}
