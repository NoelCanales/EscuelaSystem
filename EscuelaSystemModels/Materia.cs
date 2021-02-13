using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EscuelaSystemModels
{
    public class Materia : EntityBase
    {
        [Required(ErrorMessage ="El Campo Codigo de Materia no debe estar vacio")]
        [MinLength(2)] 
        [MaxLength(10)]
        [Display(Name ="Codigo de Materia")]
        public String Codigo { get; set; }
        [Required(ErrorMessage = "El campo Nombre de Materia no debe estar vacio")]
        [MinLength(3)]
        [MaxLength(25)]
        [Display(Name = "Nombre de Materia")]
        public String Descripcion { get; set; }
        [Required]
        public bool Habilitada { get; set; }
    }
}
