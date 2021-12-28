using FcMilano.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FcMilano.Areas.Admin.Controllers
{
    public class AdHomeController : Controller
    {
        // GET: Admin/AdHome
        public ActionResult AdIndex()
        {
            var messeger = new MessegerModels();
            messeger.Welcome = "Chao mung den voi admin models";
            var x = new MessegerModels();
            x.x = "Xin vui long dang nhap de su dung dich vu";
            ViewBag.Welcome = "Day la viewbag";
            return View(messeger);
            
        }
       
    }
}