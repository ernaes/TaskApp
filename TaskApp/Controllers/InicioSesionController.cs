using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskApp.Models;
namespace TaskApp.Controllers
{
    public class InicioSesionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario usuario)
        {
            try
            {
                usuario.Login();
                return RedirectToAction("Index", "Tareas");
            }catch(Exception ex)
            {
                ViewBag.Error = ex.Message;
            }

            return View("Index", usuario);
        }
    }
}
