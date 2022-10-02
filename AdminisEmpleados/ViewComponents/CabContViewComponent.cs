using AdminisEmpleados.Modelos;
using AdminisEmpleados.Servicios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminisEmpleados.ViewComponents
{
    public class CabContViewComponent : ViewComponent
    {
        private readonly IEmpleadoRepo empleadoRepo;

        public CabContViewComponent(IEmpleadoRepo empleadoRepo)
        {
            this.empleadoRepo = empleadoRepo;
        }
        public IViewComponentResult Invoke(Departamento? departNom = null)
        {
            var result = empleadoRepo.ContDepatEmpl(departNom);
            return View(result);
        }
    }
}
