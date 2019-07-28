using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace qgb48.Orders
{
    public class OrderAggregate : AggregateRoot
    {
        private IRepository<Order> _repository { get; set; }
        public OrderAggregate(IRepository<Order> repository)
        {
            _repository = repository;
        }


        public Order order;


        public void Create()
        {
            if(order!=null)
                _repository.InsertOrUpdate(order);

        }
    }
}
