using Abp.EntityFrameworkCore;
using qgb48.Test2s;
using qgb48.Tests;
using qgb48.Tests2;
using System;
using System.Collections.Generic;
using System.Text;

namespace qgb48.EntityFrameworkCore.Repositories
{
   public class Test2Repository : qgb48RepositoryBase<Test2>, ITest2Repository
    {
        public Test2Repository(IDbContextProvider<qgb48DbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
    }
}
