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

        public static Cashier GetCurrentCashier()
        {
            Model _context = new Model();
            return  _context.Cashiers.FirstOrDefault(x => x.Close == false);
        }
    }
}
