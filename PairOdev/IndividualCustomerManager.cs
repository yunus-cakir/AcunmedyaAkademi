using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairOdev
{
    public class IndividualCustomerManager
    {

        class IndividualCustomerManager { private List<IndividualCustomer> _customers = new List<IndividualCustomer>();
            public void Add(IndividualCustomer customer) { _customers.Add(customer); Console.WriteLine($"{customer.FirstName} {customer.LastName} başarıyla eklendi.");
            }
            public List<IndividualCustomer> GetList()
            { 
                return _customers;
            } 
            public void Delete(int id)
            { 
                var customer = _customers.FirstOrDefault(c => c.Id == id);
                if (customer != null) 
                { 
                    _customers.Remove(customer); Console.WriteLine($"{customer.FirstName} {customer.LastName} başarıyla silindi.");
                } 
                else 
                { 
                    Console.WriteLine("Müşteri bulunamadı!");
                }
            } 
            public IndividualCustomer GetById(int id) 
            { 
                return _customers.FirstOrDefault(c => c.Id == id);
            }
        }
    }
}
