using Deportes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Deportes.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MainPageContentController : ControllerBase
    {

        [HttpGet]
        public IActionResult ObtenerMainPage()
        {
            dynamic main_page = new System.Dynamic.ExpandoObject();
            main_page.Notificacion = new List<Estadios>()
            {
                new()
                {
                    ImageUrl = "https://img.olympics.com/images/image/private/t_s_16_9_g_auto/t_s_w860/f_auto/primary/t6dhh1fiqscihvdmxtai",
                    Nombre = "LA PLAZA DE LA CONCORDIA",
                    Capacidad = 37000
                },
                new()
                {
                    ImageUrl = "https://img.olympics.com/images/image/private/t_s_16_9_g_auto/t_s_w860/f_auto/primary/ejdtqwckzvomamusfnao",
                    Nombre = "PALACIO DE VERSALLES",
                    Capacidad = 40000
                },
                new()
                {
                    ImageUrl = "https://img.olympics.com/images/image/private/t_s_16_9_g_auto/t_s_w860/f_auto/primary/t6dhh1fiqscihvdmxtai",
                    Nombre = "TEAHUPO’O",
                    Capacidad = 600
                }
            };
            main_page.Deportes = new List<string>()
            {
                "Atletismo",
                "Natación",
                "Gimnasia artística",
                "Ciclismo (ruta y pista)",
                "Esgrima",
                "Remo",
                "Voleibol (y voleibol de playa)",
                "Boxeo",
                "Baloncesto",
                "Tenis"
            };
            return Ok(main_page);
        }
    }
}
