using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Entities;

namespace BusinessLogic
{
    public class BusinessCashier
    {
        // Método para abrir la caja

        public static Cashier OpenCashier()
        {
            try
            {
                Model _context = new Model();
                IEnumerable<Cashier> cashiers= _context.Cashiers.Where(x => x.Close == false);

                if (cashiers.Any())
                    throw new ArgumentException("Ya existe una caja abierta");

                Cashier cashier = new Cashier()
                {
                    CashierId = Guid.NewGuid(),
                    OpenDateTime = DateTime.Now,
                    Close = false,
                    CloseDateTime = null,
                    Amount = 100,
                    ToBank = 0
                };

                _context.Cashiers.Add(cashier);
                _context.SaveChanges();

                return cashier;
            }
            catch (DbEntityValidationException e)
            {               
                throw new DbEntityValidationException(e.ToString());
            }
            catch (ArgumentException e)
            {                
                throw new ArgumentException("Ya existe una caja abierta");               
            }

        }

        // Método para recuperar la caja actual

        public static Cashier GetCurrentCashier()
        {
            Model _context = new Model();
            return  _context.Cashiers.FirstOrDefault(x => x.Close == false);
        }

        // Método para cerrar caja

        public static bool CloseCurrentCashier(Guid cashierId)
        {
            Model _context = new Model();
            Cashier cashier = _context.Cashiers.Find(cashierId);
            cashier.CloseDateTime = DateTime.Now;
            cashier.Close = true;
            _context.SaveChanges();
            if (CheckCashier(cashierId))
            {
                return true;
            }
            return false;
        }

        // Método para comprobar si la caja se ha cerrado

        private static bool CheckCashier(Guid cashierId)
        {
            Model _context = new Model();
            Cashier cashier = _context.Cashiers.Find(cashierId);
            if (cashier.Close)
            {
                return true;
            }
            return false;
        }
    }
}
