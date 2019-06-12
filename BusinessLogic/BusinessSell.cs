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
    public class BusinessSell
    {
        #region CRUD Methods

        // Método para registrar una nueva venta

        public static bool InsertTicket(SellTicket sellTicket)
        {
            try
            {
                using (Model _context = new Model())
                {
                    IEnumerable<Cashier> cashiers = _context.Cashiers.ToList();
                    Cashier currentCashier = cashiers.FirstOrDefault();

                    if (!cashiers.Any()) return false;
                   
                    var virtualTicket = new SellTicket
                    {
                        UserId = sellTicket.UserId,
                        ClientId = sellTicket.ClientId,
                        Amount = sellTicket.Amount,
                        Price = sellTicket.Price,
                        SellTicketDate = sellTicket.SellTicketDate,
                        SellTicketId = sellTicket.SellTicketId,
                        CashierId =  currentCashier?.CashierId
                    };

                    foreach (var item in sellTicket.Products)
                    {
                        Stock stock = _context.Stocks.Where(x => x.ProductId.Equals(item.ProductId)).FirstOrDefault();
                        stock.SellTicketId = sellTicket.SellTicketId;
                        stock.DateOut = DateTime.Now;

                        Product product = _context.Products.Find(item.ProductId);
                        if (product != null) product.Quantity--;
                        _context.SaveChanges();
                    }

                    if (currentCashier!= null && !currentCashier.Close)
                    {
                        _context.SellTickets.Add(virtualTicket);
                        currentCashier.Amount = currentCashier.Amount + Convert.ToDouble(sellTicket.Price);
                        _context.SaveChanges();
                    }
                }

                if (HasBeenInserted(sellTicket.SellTicketId))
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


        // Método para eliminar una venta

        public static bool DeleteSellTicket(Guid id)
        {
            try
            {
                using (Model _context = new Model())
                {
                    SellTicket sellTicket = _context.SellTickets.Find(id);

                    if (sellTicket != null)
                    {
                        foreach (var item in sellTicket.Products)
                        {
                            Stock stock = _context.Stocks.Where(x => x.ProductId.Equals(item.ProductId)).FirstOrDefault();
                            stock.DateOut = null;
                            stock.SellTicketId = null;

                            Product product = _context.Products.Find(item.ProductId);
                            if (product != null) product.Quantity++;
                        }                   

                        _context.SellTickets.Attach(sellTicket);
                        _context.SellTickets.Remove(sellTicket);
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

        // Método para obtener todas las ventas

        public static IEnumerable<SellTicket> GetAllSellTickets()
        {
            Model _context = new Model();
            return _context.SellTickets;
        }

        // Método para el buscador de ventas

        public static IEnumerable<SellTicket> SearchSellTickets(string search)
        {
            using (Model _context = new Model())
            {
                IEnumerable<SellTicket> sellTickets = _context.SellTickets.Where(x => x.SellTicketDate.ToString().Contains(search) 
               || x.SellTicketId.ToString().Contains(search)).ToList();

                return sellTickets;
            }
        }

        #endregion

        #region Private Methods

        // Método privado para confirmar una inserción

        private static bool HasBeenInserted(Guid sellTicketInserted)
        {
            using (Model _context = new Model())
            {
                SellTicket sellTicket = _context.SellTickets.Find(sellTicketInserted);
                if (sellTicket != null) return true;

                return false;
            }
        }

        #endregion
    }
}
