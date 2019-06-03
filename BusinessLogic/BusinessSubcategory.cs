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
    public class BusinessSubcategory
    {
        #region CRUD Methods

        // Método para insertar una nueva subcategoria

        public static bool InsertSubcategory(Subcategory subcategory)
        {
            try
            {
                using (Model _context = new Model())
                {
                    _context.Subcategories.Add(subcategory);
                    _context.SaveChanges();
                }

                if (HasBeenInserted(subcategory.SubcategoryId))
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

        // Método para actualizar los datos de una subcategoria

        public static bool UpdateSubcategory(Subcategory subcategory)
        {
            try
            {
                using (Model _context = new Model())
                {
                    Subcategory currentSubcategory = _context.Subcategories.Find(subcategory.SubcategoryId);
                    if (currentSubcategory != null)
                    {
                        currentSubcategory.SubcategoryName = subcategory.SubcategoryName;
                        currentSubcategory.SubcategoryDescription = subcategory.SubcategoryDescription;
                        currentSubcategory.CategoryId = subcategory.CategoryId;
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

        // Método para eliminar una subcategoria

        public static bool DeleteSubcategory(Guid id)
        {
            try
            {
                using (Model _context = new Model())
                {
                    Subcategory subcategory = _context.Subcategories.Find(id);

                    if (subcategory != null)
                    {
                        _context.Subcategories.Attach(subcategory);
                        _context.Subcategories.Remove(subcategory);
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

        // Método para obtener todas las subcategorias

        public static IEnumerable<Subcategory> GetAllSubcategories()
        {
            Model _context = new Model();
            return _context.Subcategories.Include("Category");
        }

        // Método para el buscador de subcategorias

        public static IEnumerable<Subcategory> SearchSubcategory(string search)
        {
            using (Model _context = new Model())
            {
                IEnumerable<Subcategory> subcategory = _context.Subcategories.Where(x => x.SubcategoryName.Contains(search)).ToList();

                return subcategory;
            }
        }

        #endregion

        #region Private Methods

        // Método privado para confirmar una inserción

        private static bool HasBeenInserted(Guid subcategoryInserted)
        {
            using (Model _context = new Model())
            {
                Subcategory subcategory = _context.Subcategories.Find(subcategoryInserted);
                if (subcategory != null) return true;

                return false;
            }
        }

        #endregion
    }
}
