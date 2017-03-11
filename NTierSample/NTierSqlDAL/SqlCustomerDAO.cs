﻿using System;
using System.Collections.Generic;
using System.Linq;
using NTierDAL;

namespace NTierDAL.Sql
{
    internal class SqlCustomerDAO : ICustomerDAO, IDisposable
    {
        #region fields
        private readonly SqlCustomerDataContext _context;
        #endregion

        #region ctor
        public SqlCustomerDAO()
        {
            _context = new SqlCustomerDataContext();
        }
        #endregion

        #region public methods
        public ICustomerDTO Get(Guid id)
        {
            return _context.Customers.FirstOrDefault(c => c.CustomerId == id);
        }

        public IEnumerable<ICustomerDTO> GetAll()
        {
            return _context.Customers.ToList();
        }

        public void Add(ICustomerDTO itemToInsert)
        {
            _context.Customers.Add((SqlCustomerModel)itemToInsert);
            _context.SaveChanges();
        }

        public void Update(ICustomerDTO itemToUpdate)
        {
            var currentItem = (SqlCustomerModel)Get(itemToUpdate.CustomerId);
            currentItem.FirstName = itemToUpdate.FirstName;
            currentItem.LastName = itemToUpdate.LastName;
            currentItem.Age = itemToUpdate.Age;
            _context.Customers.Attach(currentItem);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var itemToRemove = (SqlCustomerModel)Get(id);
            _context.Customers.Remove(itemToRemove);
            _context.SaveChanges();
        }
        #endregion

        #region IDisposable
        public void Dispose()
        {
            if (null != _context)
                _context.Dispose();
        }
        #endregion
    }
}
