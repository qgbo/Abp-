using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Events.Bus;
using qgb48.Tests2;
using System;
using System.Collections.Generic;
using System.Text;

namespace qgb48.Test2s
{
    public class Test2 :  /*Test2Repository,*/ IAggregateRoot, ICreationAudited
    {
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }


        public string Remark { get; set; }

        public ICollection<IEventData> DomainEvents => throw new NotImplementedException();

        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsTransient()
        {
            throw new NotImplementedException();
        }
    }
}
