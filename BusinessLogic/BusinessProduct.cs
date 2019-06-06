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
    public class BusinessProduct
    {
        #region CRUD Methods

        // Método para insertar un nuevo producto

        public static bool InsertProduct(Product product)
        {
            try
            {
                using (Model _context = new Model())
                {
                    _context.Products.Add(product);
                    _context.SaveChanges();
                }

                if (HasBeenInserted(product.ProductId))
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

        // Método para actualizar los datos de un producto

        public static bool UpdateProduct(Product product)
        {
            try
            {
                using (Model _context = new Model())
                {
                    Product currentProduct = _context.Products.Find(product.ProductId);
                    if (currentProduct != null)
                    {
                        currentProduct.ProductName = product.ProductName;
                        currentProduct.ProductDescription = product.ProductDescription;
                        currentProduct.ProductId = product.ProductId;
                        currentProduct.SubcategoryId = product.SubcategoryId;
                        currentProduct.Price = product.Price;
                        //currentProduct.InDate = product.InDate;
                        //currentProduct.OutDate = product.OutDate;
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

        // Método para eliminar un producto

        public static bool DeleteProduct(Guid id)
        {
            try
            {
                using (Model _context = new Model())
                {
                    Product product = _context.Products.Find(id);

                    if (product != null)
                    {
                        _context.Products.Attach(product);
                        _context.Products.Remove(product);
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

        // Método para obtener todos los productos

        public static IEnumerable<Product> GetAllProducts()
        {
            Model _context = new Model();
            return _context.Products.Include("Subcategory");
        }

        // Método para el buscador de productos

        public static IEnumerable<Product> SearchProducts(string search)
        {
            using (Model _context = new Model())
            {
                IEnumerable<Product> products = _context.Products.Where(x => x.ProductName.Contains(search)
               ).ToList();

                return products;
            }
        }

        #endregion

        #region Private Methods

        // Método privado para confirmar una inserción

        private static bool HasBeenInserted(Guid productInserted)
        {
            using (Model _context = new Model())
            {
                Product product = _context.Products.Find(productInserted);
                if (product != null) return true;

                return false;
            }
        }

        #endregion
    }
}
