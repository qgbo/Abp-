using System;
using System.Collections.Generic;
using System.Text;

namespace qgb48.Orders
{
   public interface IOrder
    {
         long? CreatorUserId { get; set; }
         DateTime CreationTime { get; set; }

         List<OrderItem> OrderItem { get; set; }

         string Remark { get; set; }


         Address Address { get; set; }


        Order Insert(Order entity);
    }
}
