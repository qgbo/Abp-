using Abp.Dependency;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Repositories;
using Abp.Events.Bus.Entities;
using Abp.Events.Bus.Handlers;
using qgb48.TestOrders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace qgb48.Tests
{

    public class Test : AggregateRoot, ICreationAudited,
        IEventHandler<EntityCreatingEventData<TestOrder>>,
        IEventHandler<EntityCreatedEventData<TestOrder>>,
        IEventHandler<TestEvent>
    {
        public Test()
        {
           // DomainEvents.Add(new TestEvent { Id=5,Age=12,Name="暖暖"});
            
        }




        [NotMapped]
        public IRepository<Test> _repository { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }

        public string Name { get; set; }

        public string Remark { get; set; }


        public void Create()
        {
            this.Name = "gg";

            _repository.Insert(this);
        }

       
        public void HandleEvent(EntityCreatingEventData<TestOrder> eventData)
        {
            Console.WriteLine(eventData.Entity.Id);
        }

        public void HandleEvent(EntityCreatedEventData<TestOrder> eventData)
        {
            Console.WriteLine(eventData.Entity.Id);
        }

        public void HandleEvent(TestEvent eventData)
        {
            Console.WriteLine(eventData.Name);
        }
    }
}
