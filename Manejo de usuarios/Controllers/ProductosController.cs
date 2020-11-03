using Manejo_de_usuarios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Manejo_de_usuarios.Controllers
{
    public class ProductosController : Controller
    {
        List<Producto> Productos = new List<Producto>();
        public ProductosController()
        {
            Producto obj = new Producto();
            obj.cantidad = 40;
            obj.descripcion = "Manzana";
            obj.precio = 28.25m;
            Productos.Add(obj);
            
            obj.cantidad = 30;
            obj.descripcion = "Banana";
            obj.precio = 45.01m;
            Productos.Add(obj);
        }
        // GET: Productos
        public ActionResult Index()
        {
            return View();
        }
        
        public ViewResult Detalles(int id)
        {
            return View(Productos[id]);
        }

        /*
        public ActionResult Buscar(string nombreProducto)
        {            
            string res;
            switch (nombreProducto)
            {
                case "PC y TECLADO":
                    {
                        res = "Disponibles 4 unidades";
                        break;
                    }
                case "RAM":
                    {
                        res = "Disponibles 2 unidades";
                        break;  
                    }
                default:
                    {
                        res = String.Format("El producto {0} no está disponibles",nombreProducto);
                        break;
                    }                    
            }
            return Content("<p>" + res + "</p>");
        }*/
    }
}