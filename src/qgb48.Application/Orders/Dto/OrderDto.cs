using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace qgb48.Orders.Dto
{
    public class OrderDto:Entity
    {

        public List<OrderItem> OrderItem { get; set; }

        public string Remark { get; set; }

        public string Address { get; set; }


    }
}
