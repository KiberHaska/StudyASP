using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPlevel1.ViewComponents
{
    public class LoginLogoutVc : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
