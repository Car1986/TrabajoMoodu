using System.Web.Mvc;

namespace MetroUIPrueba2.Areas.Insumo
{
    public class InsumoAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Insumo";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Insumo_default",
                "Insumo/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                namespaces: new [] {"MetroUIPrueba2.Areas.Insumo.Controllers"}
            );
        }
    }
}