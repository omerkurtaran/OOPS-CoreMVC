﻿using OOPS.Core.Business;
using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.StaticAbstract
{
    public interface IPaymentRequestsService : IServiceBase
    {
        List<PaymentRequestsDTO> getAll();
    }
}
