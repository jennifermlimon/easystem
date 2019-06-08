using DataAccess;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BusinessUser
    {
        #region CRUD Methods

        // Método para insertar un nuevo usuario

        public static bool InsertUser(User user)
        {
            try
            {
                using (Model _context = new Model())
                {
                    _context.Users.Add(user);
                    _context.SaveChanges();
                }

                if (HasBeenInserted(user.UserId))
                {
                    return true;
                }

                return false;
            }
            catch (DbEntityValidationException e)
            {
                return false;
                throw new DbEntityValidationException(e.ToString());
            }
            catch (Exception e)
            {
                return false;
                throw new Exception(e.ToString());
            }
        }

        // Método para actualizar los datos de un usuario

        public static bool UpdateUser(User user)
        {
            try
            {
                using (Model _context = new Model())
                {
                    User currentuser = _context.Users.Find(user.UserId);
                    if (currentuser != null)
                    {
                        currentuser.UserName = user.UserName;
                        currentuser.UserPassword = user.UserPassword;                        
                        _context.SaveChanges();
                        return true;

                    }
                    return false;
                }
            }
            catch (DbEntityValidationException e)
            {
                return false;
                throw new Exception(e.ToString());
            }
            catch (Exception e)
            {
                return false;
                throw new Exception(e.ToString());

            }
        }

        // Método para eliminar un usuario

        public static bool DeleteUser(Guid id)
        {
            try
            {
                using (Model _context = new Model())
                {
                    User user = _context.Users.Find(id);

                    if (user != null)
                    {
                        _context.Users.Attach(user);
                        _context.Users.Remove(user);
                        _context.SaveChanges();

                        return true;
                    }

                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }

        }

        // Método para obtener todos los usuarios

        public static IEnumerable<User> GetAllUser()
        {
            Model _context = new Model();
            return _context.Users;
        }

        // Método para el buscador de usuario

        public static IEnumerable<User> Searchuser(string search)
        {
            using (Model _context = new Model())
            {
                IEnumerable<User> users = _context.Users.Where(x => x.UserName.Contains(search)).ToList();
                return users;
            }
        }
        public static User GetUserById(Guid userId)
        {
            Model _context = new Model();
            return _context.Users.Find(userId);
        }

        #endregion

        #region Private Methods

        // Método privado para confirmar una inserción

        private static bool HasBeenInserted(Guid userInserted)
        {
            using (Model _context = new Model())
            {
                User user = _context.Users.Find(userInserted);
                if (user != null) return true;

                return false;
            }
        }

        #endregion
    }
}
