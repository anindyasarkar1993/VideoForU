using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using VideoForU.Dtos;
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
        public IEnumerable<CustomerDto> GetCustomers()
        {
            return _context.Customers.ToList().Select(Mapper.Map<Customer,CustomerDto>);
        }

        public CustomerDto GetCustomer(int id)
        {
            var customer = _context.Customers.FirstOrDefault(m => m.Id == id);
            if (customer == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                return Mapper.Map<Customer, CustomerDto>(customer);
            }
        }
        [HttpPost]
        public CustomerDto CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            else
            {
                var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
                _context.Customers.Add(customer);
                _context.SaveChanges();
                customerDto.Id = customer.Id;
                return customerDto;
            }
        }

        [HttpPut]
        public void UpdateCustomer(int id, CustomerDto customerDto)
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
                    Mapper.Map<CustomerDto, Customer>(customerDto, customerinDb);
                    customerinDb.Name = customerDto.Name; 
                    customerinDb.Birthday = customerDto.Birthday;
                    customerinDb.IsSubscribedToNewsletter = customerDto.IsSubscribedToNewsletter;
                    customerinDb.MembershipTypeId = customerDto.MembershipTypeId;

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
