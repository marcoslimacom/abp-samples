﻿using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace DevExtreme.Sample.Web.Components.jQuery
{
    public class JqueryHeadViewComponent : AbpViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("/Components/jQuery/Default.cshtml");
        }
    }
}