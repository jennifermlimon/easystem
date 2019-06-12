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
                };

                _context.Cashiers.Add(cashier);
                _context.SaveChanges();

                return cashier;
            }
            catch (DbEntityValidationException e)
            {
                return null;
                throw new DbEntityValidationException(e.ToString());
            }
            catch (Exception e)
            {
                return null;
                throw new Exception(e.ToString());
            }

        }
    }
}
