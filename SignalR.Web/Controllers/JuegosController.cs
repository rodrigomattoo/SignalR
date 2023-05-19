using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SignalR.Web.Controllers
{
    public class JuegosController : Controller
    {
        // GET: JuegosController
        public ActionResult RompeCabezas()
        {
            return View();
        }
    }
}
