using Abp.Application.Services;
using Abp.Domain.Repositories;
using Castle.Core.Logging;
using qgb48.Orders.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace qgb48.Orders
{
    public  class OrderAppService: ApplicationService, IOrderAppService
    {
        private IOrderManage _orderManage;

        IOrder _orderAggregate;

        public OrderAppService(IOrderManage orderManage, IOrder orderAggregate)
        {
            _orderManage = orderManage;
            _orderAggregate = orderAggregate;
        }



        public void  CreateOrUpdate(OrderDto dto)
        {

            var order = new Order();
           // order.Address = dto.Address;
            order.Id = dto.Id;
            order.Remark = dto.Remark;
           // order.Address = dto.Address;
            order.OrderItem = dto.OrderItem;
            // _orderAggregate.order = order;
            _orderAggregate.Insert(order);
        }

        public Order[] GetAll()
        {
           return _orderManage.GetAll();
        }
    }
}
