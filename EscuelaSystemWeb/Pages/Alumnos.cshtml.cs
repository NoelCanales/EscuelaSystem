using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EscuelaSystem.Data.Interfaces;
using EscuelaSystemModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EscuelaSystemWeb.Pages 
{
    public class AlumnosModel : PageModel
    {

        private readonly IAlumnoRepository _alumnoRepository;

        public AlumnosModel(IAlumnoRepository alumnoRepository)
        {
            _alumnoRepository = alumnoRepository;
        }

        [BindProperty]
        public IEnumerable<Alumno> Alumnos { get; set; }

        public IActionResult OnGet()
        {

            Alumnos = _alumnoRepository.List();
            return Page();
        }
    }
}
