using DataAccess;
using DataAccess.Entities;
using System;
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

        public void CreateFirstUser()
        {
            User user = new User { UserId = Guid.NewGuid(), UserName = "admin123", UserPassword = "admin123" };
            Model _context = new Model();
            _context.Users.Add(user);
            _context.SaveChanges();
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
