using DataAccess;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;

namespace BusinessLogic
{
    public class BusinessCustomer
    {
        #region CRUD Methods

        // Método para insertar un nuevo cliente

        public static bool InsertCustomer(Client client)
        {
            try
            {
                using (Model _context = new Model())
                {
                    _context.Clients.Add(client);
                    _context.SaveChanges();
                }

                if (HasBeenInserted(client.ClientId))
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

        // Método para actualizar los datos de un cliente

        public static bool UpdateCustomer(Client client)
        {
            try
            {
                using (Model _context = new Model())
                {
                    Client currentClient = _context.Clients.Find(client.ClientId);
                    if (currentClient != null)
                    {
                        currentClient.ClientName = client.ClientName;
                        currentClient.ClientAdress = client.ClientAdress;
                        currentClient.ClientEmail = client.ClientEmail;
                        currentClient.ClientNif = client.ClientNif;
                        currentClient.ClientSurname1 = client.ClientSurname1;
                        currentClient.ClientSurname2 = client.ClientSurname2;
                        currentClient.CLientTelephone = client.CLientTelephone;
                        currentClient.ClientDateOfBirth = client.ClientDateOfBirth;
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

        // Método para eliminar un cliente

        public static bool DeleteCustomer(Guid id)
        {
            try
            {
                using (Model _context = new Model())
                {
                    Client client = _context.Clients.Find(id);

                    if (client != null)
                    {
                        _context.Clients.Attach(client);
                        _context.Clients.Remove(client);
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

        // Método para obtener todos los clientes

        public static IEnumerable<Client> GetAllCustomer()
        {
            Model _context = new Model();
            return _context.Clients;
        }

        // Método para el buscador de cliente

        public static IEnumerable<Client> SearchClient(string search)
        {
            using (Model _context = new Model())
            {
                IEnumerable<Client> clients =  _context.Clients.Where(x => x.ClientName.Contains(search)
                                                       || x.ClientSurname1.Contains(search)
                                                       || x.ClientNif.Contains(search)
                                                       || x.ClientSurname2.Contains(search)).ToList();
                return clients;
            }      
        }

        // Método para buscar cliente por código

        public static Client GetClientById(Guid clientId)
        {
            Model _context = new Model();
            return _context.Clients.Find(clientId);
        }

        #endregion

        #region Private Methods

        // Método privado para confirmar una inserción

        private static bool HasBeenInserted(Guid clientInserted)
        {
            using (Model _context = new Model())
            {
                Client client = _context.Clients.Find(clientInserted);
                if (client != null) return true;

                return false;
            }
        }

        #endregion
    }
}
