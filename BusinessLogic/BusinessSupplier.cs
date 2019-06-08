using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Entities;

namespace BusinessLogic
{
    public class BusinessSupplier
    {
        #region CRUD Methods

        // Método para insertar un nuevo proveedor

        public static bool InsertSupplier(Supplier supplier)
        {
            try
            {
                using (Model _context = new Model())
                {
                    _context.Suppliers.Add(supplier);
                    _context.SaveChanges();
                }

                if (HasBeenInserted(supplier.SupplierId))
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

        // Método para actualizar los datos de un proveedor

        public static bool UpdateSupplier(Supplier supplier)
        {
            try
            {
                using (Model _context = new Model())
                {
                    Supplier currentSupplier = _context.Suppliers.Find(supplier.SupplierId);
                    if (currentSupplier != null)
                    {
                        currentSupplier.SupplierName = supplier.SupplierName;
                        currentSupplier.SupplierAdress = supplier.SupplierAdress;
                        currentSupplier.SupplierEmail = supplier.SupplierEmail;
                        currentSupplier.SupplierCif = supplier.SupplierCif;
                        currentSupplier.SupplierTelephone = supplier.SupplierTelephone;                      
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

        // Método para eliminar un proveedor

        public static bool DeleteSupplier(Guid id)
        {
            try
            {
                using (Model _context = new Model())
                {
                    Supplier supplier = _context.Suppliers.Find(id);

                    if (supplier != null)
                    {
                        _context.Suppliers.Attach(supplier);
                        _context.Suppliers.Remove(supplier);
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

        // Método para obtener todos los proveedores

        public static IEnumerable<Supplier> GetAllSuppliers()
        {
            Model _context = new Model();
            return _context.Suppliers;
        }

        // Método para el buscador de proveedor

        public static IEnumerable<Supplier> SearchSupplier(string search)
        {
            using (Model _context = new Model())
            {
                IEnumerable<Supplier> suppliers = _context.Suppliers.Where(x => x.SupplierName.Contains(search)                                                   
                                                      || x.SupplierCif.Contains(search)).ToList();
                return suppliers;
            }
        }
        
        // Método para obtener un proveedor por ID

        public static Supplier GetSupplierById (Guid Id)
        {
            Model _context = new Model();
            return _context.Suppliers.Find(Id);
        }

        #endregion

        #region Private Methods

        // Método privado para confirmar una inserción

        private static bool HasBeenInserted(Guid supplierInserted)
        {
            using (Model _context = new Model())
            {
                Supplier supplier = _context.Suppliers.Find(supplierInserted);
                if (supplier != null) return true;

                return false;
            }
        }

        #endregion
    }

}
