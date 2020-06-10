﻿using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class PermitsViewComponent : ViewComponent
    {
        private readonly IPermitService permitService;

        public PermitsViewComponent(IPermitService _permitService)
        {
            permitService = _permitService;
        }

        public IViewComponentResult Invoke()
        {
            //var companyId = CurrentUser.companyId;
            //var companyId = 1;
            return View(permitService.getAllEmployeePermits());
        }
    }
}
