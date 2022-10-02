using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminisEmpleados.Modelos;
using AdminisEmpleados.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdminisEmpleados.Pages.Empleados
{
    public class IndexModel : PageModel
    {
        private readonly IEmpleadoRepo empleadoRepo;
        public IEnumerable<Empleado> Empleados { get; set; }
        [BindProperty(SupportsGet =true)]
        public string TermBusq { get; set; }
        public IndexModel(IEmpleadoRepo empleadoRepo)
        {
            this.empleadoRepo = empleadoRepo;
        }
        public void OnGet()
        {
            Empleados = empleadoRepo.BuscEmpl(TermBusq);
        }
    }
}
