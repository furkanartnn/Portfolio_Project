using Business_Layer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Concrete
{
    public class UserMessageManager : IUserMessageService
    {
        IUserMessageDal _userrMessageDal;

        public UserMessageManager(IUserMessageDal userrMessageDal)
        {
            _userrMessageDal = userrMessageDal;
        }

        public List<UserMessage> GetUSerMessageWithUSerService()
        {
            return _userrMessageDal.GetUserMessagesWithUSer();
        }

        public void TAdd(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public UserMessage TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserMessage> TGetList()
        {
            return _userrMessageDal.GetList();
        }

        public void TUpdate(UserMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
