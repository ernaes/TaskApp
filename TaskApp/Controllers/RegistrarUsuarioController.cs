using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskApp.Models;

namespace TaskApp.Controllers
{
    public class RegistrarUsuarioController : Controller
    {
        public IActionResult Index(Usuario usuario=null)
        {
            if (usuario == null)
            {
                usuario = new Usuario();
            }
            return View(usuario);
        }

        [HttpPost]
        public IActionResult RegistroExitoso(Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index",usuario);
            }
            usuario.Guardar();
            return View(usuario);
        }
    }
}
