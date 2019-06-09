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
    public class BussinesBuy
    {
        #region CRUD Methods

        // Método para registrar una nueva compra

        public static bool InsertTicket(BuyTicket buyticket)
        {
            try
            {
                using (Model _context = new Model())
                {
                    var virtualTicket = new BuyTicket
                    {
                        Amount = buyticket.Amount,
                        BuyTicketDate = buyticket.BuyTicketDate,
                        BuyTicketId = buyticket.BuyTicketId,
                        Price = buyticket.Price,
                        SupplierId = buyticket.SupplierId,
                        UserId = buyticket.UserId
                    };
                    _context.BuyTickets.Add(virtualTicket);
                    _context.SaveChanges();
                    foreach (var item in buyticket.Products)
                    {
                        _context.Stocks.Add(new Stock { BuyTicketId = buyticket.BuyTicketId, DateIn = buyticket.BuyTicketDate, DateOut = null, ProductId = item.ProductId, SellTicketId = null, StockId = Guid.NewGuid() });
                        Product product = _context.Products.Find(item.ProductId);
                        if (product != null) product.Quantity++;
                        _context.SaveChanges();
                    }
                }

                if (HasBeenInserted(buyticket.BuyTicketId))
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

            
        // Método para eliminar una compra

        public static bool DeleteBuyTicket(Guid id)
        {
            try
            {
                using (Model _context = new Model())
                {
                    BuyTicket buyticket = _context.BuyTickets.Find(id);

                    if (buyticket != null)
                    {
                        _context.BuyTickets.Attach(buyticket);
                        _context.BuyTickets.Remove(buyticket);
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

        // Método para obtener todas las compras

        public static IEnumerable<BuyTicket> GetAllBuyTickets()
        {
            Model _context = new Model();
            return _context.BuyTickets;
        }

        // Método para el buscador de compras

        public static IEnumerable<BuyTicket> SearchBuyTickets(string search)
        {
            using (Model _context = new Model())
            {
                IEnumerable<BuyTicket> buyTickets = _context.BuyTickets.Where(x => x.BuyTicketDate.ToString().Contains(search)
               ).ToList();

                return buyTickets;
            }
        }

        #endregion

        #region Private Methods

        // Método privado para confirmar una inserción

        private static bool HasBeenInserted(Guid buyTicketInserted)
        {
            using (Model _context = new Model())
            {
                BuyTicket buyTicket = _context.BuyTickets.Find(buyTicketInserted);
                if (buyTicket != null) return true;

                return false;
            }
        }

        #endregion
    }
}
