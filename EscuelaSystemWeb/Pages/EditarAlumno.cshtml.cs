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
    public class EditarAlumnoModel : PageModel
    {

        private readonly IAlumnoRepository _alumnoRepository;

        public EditarAlumnoModel(IAlumnoRepository alumnoRepository)
        {
            _alumnoRepository = alumnoRepository;
        }

        [BindProperty]
        public Alumno Alumno { get; set; }
        public ActionResult OnGet(int id)
        {
            Alumno = _alumnoRepository.GetById(id);
            if (Alumno == null)
            {
                return NotFound();
            }
            return Page();
        }

        public ActionResult OnPost(int id)
        {
            if (ModelState.IsValid)
            {
                return Page();

            }
            var AlumnoUpdate = _alumnoRepository.GetById(id);
            if (AlumnoUpdate == null)
            {
                return NotFound();


            }
            AlumnoUpdate.Codigo = Alumno.Codigo;
            AlumnoUpdate.Nombre = Alumno.Nombre;
            AlumnoUpdate.Activo= Alumno.Activo;

            _alumnoRepository.Update(AlumnoUpdate);

            return RedirectToPage("./Alumnos");
        }

    }
}

