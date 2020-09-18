using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VideoForU.Models;

namespace VideoForU.Controllers.API
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context=new ApplicationDbContext();
        }
        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }

        public Customer GetCustomer(int id)
        {
            var customer = _context.Customers.FirstOrDefault(m => m.Id == id);
            if (customer == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                return customer;
            }
        }
        [HttpPost]
        public Customer CreateCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            else
            {
                _context.Customers.Add(customer);
                _context.SaveChanges();
                return customer;
            }
        }

        [HttpPut]
        public void UpdateCustomer(int id, Customer customer)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            else
            {
                var customerinDb= _context.Customers.FirstOrDefault(m => m.Id == id);
                if (customerinDb == null)
                {
                    throw new  HttpResponseException(HttpStatusCode.NotFound);
                }
                else
                {
                    customerinDb.Name = customer.Name; 
                    customerinDb.Birthday = customer.Birthday;
                    customerinDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
                    customerinDb.MembershipTypeId = customer.MembershipTypeId;

                    _context.SaveChanges();
                }
            }
        }
        [HttpDelete]

        public void DeleteCustomer(int id)
        {
            var customerinDb = _context.Customers.FirstOrDefault(m => m.Id == id);
            if (customerinDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                _context.Customers.Remove(customerinDb);
                _context.SaveChanges();
            }
            
        }
    }
}
