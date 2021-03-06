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
    public class CrearAlumnoModel : PageModel
    {
        private readonly IAlumnoRepository _alumnoRepository;

        public CrearAlumnoModel(IAlumnoRepository alumnoRepository)
        {
            _alumnoRepository = alumnoRepository;
        }

        [BindProperty]
        public Alumno Alumno { get; set; }
        public void OnGet()
        {

        }

        public ActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                return Page();

            }

            _alumnoRepository.Insert(Alumno);

            return RedirectToPage("./Alumnos");
        }


    }
}

