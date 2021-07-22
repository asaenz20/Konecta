using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Konecta.Controllers
{
    public class SolicitudesController : Controller
    {
        private ContextKonectaMVC _context;
        public SolicitudesController()
        {
            _context = new ContextKonectaMVC();
        }
        public ActionResult Index()
        {
            var Solicitudes = _context.Solicitud.ToList();
            return View(Solicitudes);
        }
        public ActionResult Edit(int ID)
        {
            var Solicitud = _context.Solicitud.FirstOrDefault(solicitud => solicitud.ID==ID);
            return View(Solicitud);
        }
        [HttpPost]
        public ActionResult Save(Solicitud solicitud)
        {
            var Solicitud_OLD = _context.Solicitud.FirstOrDefault(s => s.ID == solicitud.ID);
            if (Solicitud_OLD != null)
            {
                Solicitud_OLD.DESCRIPCION = solicitud.DESCRIPCION;
                Solicitud_OLD.CODIGO = solicitud.CODIGO;
                Solicitud_OLD.RESUMEN = solicitud.RESUMEN;
                Solicitud_OLD.ID_EMPLEADO = solicitud.ID_EMPLEADO;
                _context.SaveChanges();
            }
            return Redirect("index");
        }
        
        public ActionResult Delete(int ID)
        {
            var Solicitud = _context.Solicitud.FirstOrDefault(solicitud => solicitud.ID == ID);
            _context.Solicitud.Remove(Solicitud);
            _context.SaveChanges();
           return Redirect("/solicitudes/index");
        }
        public ActionResult Create()
        {
            Solicitud solicitud = new Solicitud();
            return View(solicitud);
        }
        [HttpPost]
        public ActionResult SaveNew(Solicitud solicitud)
        {
            _context.Solicitud.Add(solicitud);
            _context.SaveChanges();
            return Redirect("index");
        }
    }
}