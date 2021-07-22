using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Konecta;

namespace Konecta.Utiles
{
    public class Utiles
    {
        private ContextKonectaMVC _context;
        public Utiles()
        {
            this._context = new ContextKonectaMVC();
        }
        public List<Empleado> ListarEmpleados()
        {
            return _context.Empleado.ToList();
        }
        public List<Solicitud> ListarSolicitudes()
        {
            return _context.Solicitud.ToList();
        }
        
    }
}