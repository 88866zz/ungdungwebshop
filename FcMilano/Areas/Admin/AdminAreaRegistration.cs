using System.Web.Mvc;

namespace FcMilano.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "AdIndex", Controllers = "AdHome", id = UrlParameter.Optional },
                namespaces: new[] { "FcMilano.Areas.Admin.Controllers" }
            );
        }
    }
}