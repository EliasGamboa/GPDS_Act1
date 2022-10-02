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
    public class BorrarModel : PageModel
    {
        private readonly IEmpleadoRepo empleadoRepo;
        public BorrarModel(IEmpleadoRepo empleadoRepo)
        {
            this.empleadoRepo = empleadoRepo;
        }
        [BindProperty]
        public Empleado Empleado { get; set; }
        public IActionResult OnGet(int id)
        {
            Empleado = empleadoRepo.ObtEmpleado(id);
            if (Empleado == null)
            {
                return RedirectToPage("/EmplNoEncont");
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            Empleado empleadoBorr = empleadoRepo.BorrEmpleado(Empleado.Id);
            if(empleadoRepo == null)
            {
                return RedirectToPage("/EmplNoEncont");
            }
            return RedirectToPage("Index");
        }
    }
}
