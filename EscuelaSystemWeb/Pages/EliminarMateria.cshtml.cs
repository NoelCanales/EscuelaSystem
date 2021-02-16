using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EscuelaSystemDATA.Interfaces;
using EscuelaSystemModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EscuelaSystemWeb.Pages
{

    public class EliminarMateriaModel : PageModel
    {
        private readonly IMateriaRepository _materiaRepository;

        public EliminarMateriaModel(IMateriaRepository materiaRepository)
        {
            _materiaRepository = materiaRepository;
        }

        [BindProperty]
        public Materia Materia { get; set; }
        public ActionResult OnGet(int id)
        {
            Materia = _materiaRepository.GetById(id);
            if (Materia == null)
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
            var MateriaDelete = _materiaRepository.GetById(id);
            if (MateriaDelete == null)
            {
                return NotFound();


            }
            MateriaDelete.Codigo = Materia.Codigo;
            MateriaDelete.Descripcion = Materia.Descripcion;
            MateriaDelete.Habilitada = Materia.Habilitada;

            _materiaRepository.Delete(MateriaDelete);

            return RedirectToPage("./Materias");
        }

    }
}