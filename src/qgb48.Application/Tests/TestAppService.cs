using Abp.Application.Services;
using Abp.Dependency;
using qgb48.Tests.Dto.TestDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace qgb48.Tests
{
    public class TestAppService:ApplicationService, ITestAppService
    {
        private readonly IIocResolver _iocResolver;

        public TestAppService(IIocResolver iocResolver)
        {
            _iocResolver = iocResolver;
        }



        public void Create(TestDto testDto)
        {

            //Resolving and using in a safe way
            using (var personService2 = _iocResolver.ResolveAsDisposable<Test>())
            {
                personService2.Object.Create();
            }
        }
    }
}
