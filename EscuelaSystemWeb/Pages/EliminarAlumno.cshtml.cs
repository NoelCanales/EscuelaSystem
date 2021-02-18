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
    public class EliminarAlumnoModel : PageModel
    {
        private readonly IAlumnoRepository _alumnoRepository;

        public EliminarAlumnoModel(IAlumnoRepository alumnoRepository)
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
            var AlumnoDelete = _alumnoRepository.GetById(id);
            if (AlumnoDelete == null)
            {
                return NotFound();


            }
            AlumnoDelete.Codigo = Alumno.Codigo;
            AlumnoDelete.Nombre = Alumno.Nombre;
            AlumnoDelete.Activo = Alumno.Activo;

            _alumnoRepository.Delete(AlumnoDelete);

            return RedirectToPage("./Alumnos");
        }

    }
}
