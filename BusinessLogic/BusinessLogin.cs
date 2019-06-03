using DataAccess;
using DataAccess.Entities;
using System.Linq;

namespace BusinessLogic
{
    public class BusinessLogin
    {
        private string _userName;
        private string _password;
        Model context = new Model();

        public BusinessLogin(string userName, string password)
        {
            this._userName = userName;
            this._password = password;
        }

        public bool CheckUser()
        {
            User user = this.context.Users.Where(u => u.UserName.Equals(this._userName) 
                                                   && u.UserPassword.Equals(this._password)).FirstOrDefault();

            if (user != null)
            {
                return true;
            }

            return false;
        }
    }
}
