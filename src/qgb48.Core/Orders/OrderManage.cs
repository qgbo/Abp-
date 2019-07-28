using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace qgb48.Orders
{
    public class OrderManage: DomainService, IOrderManage
    {
        private readonly IRepository<Order> _repositoy;
        public OrderManage(IRepository<Order> repositoy)
        {
            _repositoy = repositoy;
        }
        public Order[] GetAll()
        {
            return _repositoy.GetAllList().ToArray();
        }

    }
}
