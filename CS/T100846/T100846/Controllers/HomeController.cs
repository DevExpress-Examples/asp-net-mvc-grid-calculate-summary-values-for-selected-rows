using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using MVCxGridViewDataBinding.Models;

namespace T100846.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }


        [ValidateInput(false)]
        public ActionResult GridViewPartial()
        {
            var model = MyModel.GetModelList();
            return PartialView("_GridViewPartial", model);
        }
    }
}
