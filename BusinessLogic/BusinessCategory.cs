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
    public class BusinessCategory
    {

        #region CRUD Methods

        // Método para insertar una nueva categoria

        public static bool InsertCategory(Category category)
        {
            try
            {
                using (Model _context = new Model())
                {
                    _context.Categories.Add(category);
                    _context.SaveChanges();
                }

                if (HasBeenInserted(category.CategoryId))
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

        // Método para actualizar los datos de una categoria

        public static bool UpdateCategory(Category category)
        {
            try
            {
                using (Model _context = new Model())
                {
                    Category currentCategory = _context.Categories.Find(category.CategoryId);
                    if (currentCategory != null)
                    {
                        currentCategory.CategoryName = category.CategoryName;
                        currentCategory.CategoryDescription = category.CategoryDescription;                       
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

        // Método para eliminar una categoria

        public static bool DeleteCategory(Guid id)
        {
            try
            {
                using (Model _context = new Model())
                {
                    Category category = _context.Categories.Find(id);

                    if (category != null)
                    {
                        _context.Categories.Attach(category);
                        _context.Categories.Remove(category);
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

        // Método para obtener todas las categorias

        public static IEnumerable<Category> GetAllCategories()
        {
            Model _context = new Model();
            return _context.Categories;
        }

        // Método para el buscador de categorias

        public static IEnumerable<Category> SearchCategory(string search)
        {
            using (Model _context = new Model())
            {
                IEnumerable<Category> category = _context.Categories.Where(x => x.CategoryName.Contains(search)).ToList();                                                   
                                                   
                return category;
            }
        }

        // Metodo para buscar categoria por Id

        public static Category GetCategoryById(Guid categoryId)
        {
            using (Model _context = new Model())
            {
                Category category = _context.Categories.Find(categoryId);
                if (category != null) return category;

                return null;
            }
        }

        #endregion

        #region Private Methods

        // Método privado para confirmar una inserción

        private static bool HasBeenInserted(Guid categoryInserted)
        {
            using (Model _context = new Model())
            {
                Category category = _context.Categories.Find(categoryInserted);
                if (category != null) return true;

                return false;
            }
        }

        #endregion
    }
}
