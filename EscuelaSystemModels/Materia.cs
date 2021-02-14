using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EscuelaSystemModels
{
    public class Materia : EntityBase
    {
        [Required(ErrorMessage ="El Campo Codigo de Materia no debe estar vacio")]
        [MinLength(2, ErrorMessage ="El campo debe tener minimo 2 caracteres")] 
        [MaxLength(10)]
        [Display(Name ="Codigo de Materia")]
        public String Codigo { get; set; }
        [Required(ErrorMessage = "El campo Nombre de Materia no debe estar vacio")]
        [MinLength(3, ErrorMessage = "El campo debe tener minimo 3 caracteres")]
        [MaxLength(25, ErrorMessage = "El campo Nombre de Matera debe tener maximo 25 caracteres")]
        [Display(Name = "Nombre de Materia")]
        public String Descripcion { get; set; }
        [Required]
        public bool Habilitada { get; set; }
    }
}
