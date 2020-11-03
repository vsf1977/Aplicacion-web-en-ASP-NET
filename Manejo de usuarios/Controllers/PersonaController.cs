using Manejo_de_usuarios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace Manejo_de_usuarios.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Persona(int id, string nombre, string apellido)
        {
            Persona obj = new Persona();
            obj.id = id;
            obj.nombre = nombre;
            obj.apellido = apellido;            
            return View(obj);
        }

        public ActionResult Index()
        {           
           return View();
        }
    }
}