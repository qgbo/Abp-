using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace qgb48.Orders
{
    [Table("OrderItem", Schema = "bloggingss")]
    public class OrderItem:Entity, IHasCreationTime
    {
        public int OrderId { get; set; }
        public float Price { get; set; }
        public string Name { get; set; }
        public int Num { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
