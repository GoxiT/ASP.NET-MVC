﻿using PizzaApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaApp.DataAccess
{
    public class OrderRepository : IRepository<Order>
    {
        private PizzaDbContext _dbContext;

        public OrderRepository(PizzaDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public List<Order> GetAll()
        {
            return _dbContext.Orders.ToList();
        }

        public Order GetById(int id)
        {
            return _dbContext.Orders.SingleOrDefault(x => x.Id == id);
        }

        public void Create(Order entity)
        {
            _dbContext.Orders.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(Order entity)
        {
            Order order = _dbContext.Orders.SingleOrDefault(x => x.Id == entity.Id);
            if (order != null)
            {
                _dbContext.Orders.Update(entity);
                _dbContext.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            Order order = _dbContext.Orders.SingleOrDefault(x => x.Id == Id);
            _dbContext.Orders.Remove(order);
            _dbContext.SaveChanges();
        }
    }
}
