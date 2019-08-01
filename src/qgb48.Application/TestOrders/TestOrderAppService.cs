using Abp.Application.Services;
using Abp.Dependency;
using Abp.Events.Bus;
using Abp.Events.Bus.Entities;
using qgb48.Tests;
using System;
using System.Collections.Generic;
using System.Text;

namespace qgb48.TestOrders
{
    public class TestOrderAppService: ApplicationService
    {
        private readonly IIocResolver _iocResolver;
        public IEventBus EventBus { get; set; }

   
        public TestOrderAppService(IIocResolver iocResolver)
        {
            _iocResolver = iocResolver;
            EventBus = NullEventBus.Instance;
        }



        public void Create()
        {
            //Resolving and using in a safe way
            using (var test = _iocResolver.ResolveAsDisposable<TestOrder>())
            {
                test.Object.Create();
            }
        }

        /// <summary>
        ///  触发领域事件
        /// </summary>
        public void Trigger()
        {
            var e = new EntityCreatingEventData<TestOrder>(new TestOrder() {  TestOrderName= "Trigger" ,TestOrderRemark="asdfff"});

            //Resolving and using in a safe way
            EventBus.Trigger(e);
        }


        public void TriggerCustomEvent()
        {
            var e = new TestEvent() { Name="nn",Id=34};

            //Resolving and using in a safe way
            EventBus.Trigger(e);
        }
    }
}
