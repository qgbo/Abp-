using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace qgb48.Tests
{

    public class Test : AggregateRoot, ICreationAudited
    {
        [NotMapped]
        // public ITestRepository _repository { get; set; }
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
    }
}
