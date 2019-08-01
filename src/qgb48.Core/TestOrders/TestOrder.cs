using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Repositories;
using Abp.Events.Bus.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace qgb48.TestOrders
{
    

    public class TestOrder : AggregateRoot, ICreationAudited
    {
        [NotMapped]
        public IRepository<TestOrder> _repository { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }

        public string TestOrderName { get; set; }

        public string TestOrderRemark { get; set; }


        public void Create()
        {
            this.TestOrderName = "ggsss";

            _repository.Insert(this);
        }
    }
}
