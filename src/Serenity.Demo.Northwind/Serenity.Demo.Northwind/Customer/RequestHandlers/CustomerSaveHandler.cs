﻿using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Serenity.Demo.Northwind.Entities.CustomerRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Serenity.Demo.Northwind.Entities.CustomerRow;

namespace Serenity.Demo.Northwind
{
    public interface ICustomerSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse>,
        IUpdateHandler<MyRow, MyRequest, MyResponse>
    {
    }

    public class CustomerSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICustomerSaveHandler
    {
        public CustomerSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}