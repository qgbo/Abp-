using Abp.Dependency;
using Abp.Events.Bus.Entities;
using Abp.Events.Bus.Handlers;
using qgb48.TestOrders;
using System;
using System.Collections.Generic;
using System.Text;

namespace qgb48.TestEventBus
{
    public class TestEventBus : IEventHandler<EntityCreatingEventData<TestOrder>>, ITransientDependency
    {
        public void HandleEvent(EntityCreatingEventData<TestOrder> eventData)
        {
           
        }
    }
}
