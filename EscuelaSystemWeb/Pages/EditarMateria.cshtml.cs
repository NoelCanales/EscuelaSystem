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
    public class EditarMateriaModel : PageModel
    {
        private readonly IMateriaRepository _materiaRepository;

        public EditarMateriaModel(IMateriaRepository materiaRepository)
        {
            _materiaRepository = materiaRepository;
        }

        [BindProperty]
        public Materia Materia { get; set; }
        public ActionResult OnGet(int Id)
        {
            Materia = _materiaRepository.GetById(Id);
            if (Materia==null)
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
            var MateriaUpdate = _materiaRepository.GetById(id);
            if (MateriaUpdate == null)
            {
                return NotFound();

              

            }
                MateriaUpdate.Codigo = Materia.Codigo;
                MateriaUpdate.Descripcion = Materia.Descripcion;
                MateriaUpdate.Habilitada = Materia.Habilitada;

            _materiaRepository.Update(MateriaUpdate);

            return RedirectToAction("./Materias");
        }

    }
}
