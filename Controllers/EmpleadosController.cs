using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Konecta.Controllers
{
    public class EmpleadosController : Controller
    {
        private ContextKonectaMVC _context;
        public EmpleadosController()
        {
            _context = new ContextKonectaMVC();
        }
        public ActionResult Index()
        {
            var Empleado = _context.Empleado.ToList();
            return View(Empleado);
        }
        public ActionResult Edit(int ID)
        { 
            var Empleado = _context.Empleado.FirstOrDefault(e => e.ID == ID);
            return View(Empleado);
        }
        [HttpPost]
        public ActionResult Save(Empleado empleado)
        {
            var Empleado_OLD = _context.Empleado.FirstOrDefault(s => s.ID == empleado.ID);
            if (Empleado_OLD != null)
            {
                Empleado_OLD.NOMBRE = empleado.NOMBRE;
                Empleado_OLD.SALARIO = empleado.SALARIO;
                Empleado_OLD.FECHA_INGRESO = empleado.FECHA_INGRESO;
                Empleado_OLD.ID = empleado.ID;
                _context.SaveChanges();
            }
            return Redirect("index");
        }

        public ActionResult Delete(int ID)
        {
            var Empleado = _context.Empleado.FirstOrDefault(s => s.ID == ID);
            _context.Empleado.Remove(Empleado);
            _context.SaveChanges();
            return Redirect("/empleados/index");
        }
        public ActionResult Create()
        {
            Empleado empleado = new Empleado();
            return View(empleado);
        }
        [HttpPost]
        public ActionResult SaveNew(Empleado empleado)
        {
            _context.Empleado.Add(empleado);
            _context.SaveChanges();
            return Redirect("index");
        }
    }
}