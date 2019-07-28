using Abp.EntityFrameworkCore;
using qgb48.Test2s;
using qgb48.Tests2;
using System;
using System.Collections.Generic;
using System.Text;

namespace qgb48.EntityFrameworkCore.Repositories
{
   public class TestRepository : qgb48RepositoryBase<Test2>, ITest2Repository
    {
        public TestRepository(IDbContextProvider<qgb48DbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
    }
}
