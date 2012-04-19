using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MVCSPAApplication.ViewModels;

namespace MVCSPAApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Acercade()
        {
            return View();
        }

        public ActionResult Contacto()
        {
            return View();
        }

        public ActionResult Productos(int categoria)
        {
            List<ProductoVM> productos;
            if (categoria == 1)
            {
                ViewBag.Categoria = "Categoria 1";
                productos = new List<ProductoVM>() {
                    new ProductoVM { Nombre= "Producto 1", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 2", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 3", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 4", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 5", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 6", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 7", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 8", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 9", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 10", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 11", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 12", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 13", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 14", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" }
                };
                return View(productos);
            }
            else if (categoria == 2)
            {
                ViewBag.Categoria = "Categoria 2";
                productos = new List<ProductoVM>() {
                    new ProductoVM { Nombre= "Producto 1", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 2", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 3", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 4", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 5", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 6", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 7", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 8", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 9", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" }
                 };
                return View(productos);

            }
            else
            {
                ViewBag.Categoria = "Categoria 3";
                productos = new List<ProductoVM>() {
                    new ProductoVM { Nombre= "Producto 1", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 2", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 3", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 4", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 5", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 6", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 7", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 8", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 9", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 10", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 11", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 12", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 13", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 14", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 15", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 16", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 17", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 18", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 19", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 20", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 21", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 22", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 23", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 24", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 25", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 26", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" },
                    new ProductoVM { Nombre= "Producto 27", Descripcion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla metus elit, egestas eu malesuada id" }
                 };
                return View(productos);
            }
        }

    }
}
