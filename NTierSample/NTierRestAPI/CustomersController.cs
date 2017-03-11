using System;
using System.Collections.Generic;
using System.Web.Http;
using Newtonsoft.Json;
using NTierBusiness;
using NTierBusiness.Services;

namespace NTierRestAPI
{
    // localhost:8080/api/customers
    public class CustomersController : ApiController
    {
        private readonly ICustomerBOService _service;

        public CustomersController()
        {
            _service = new CustomerBOService();
        }

        // GET api/customers 
        public IEnumerable<ICustomerBO> Get()
        {
            return _service.GetCustomers();
        }

        // GET api/customers/{id} 
        public ICustomerBO Get(Guid id)
        {
            return _service.GetCustomer(id);
        }

        // POST api/customers 
        public void Post(CustomerBO customer)
        {
            _service.Save(customer);
        }

        // PUT api/customers/{id} 
        public void Put(Guid id, CustomerBO customer)
        {
            customer.Id = id;
            _service.Save(customer);
        }

        // DELETE api/customers/{id} 
        public void Delete(Guid id)
        {
            _service.Delete(id);
        }
    }
}