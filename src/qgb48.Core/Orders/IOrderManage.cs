using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace qgb48.Orders
{
    public interface IOrderManage:IDomainService
    {
        Order[] GetAll();
    }
}
