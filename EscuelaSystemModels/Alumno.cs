using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EscuelaSystemModels
{
    public class Alumno : IEntityTypeConfiguration
    {
            [Required(ErrorMessage = "El Campo Codigo de Alumno no debe estar vacio")]
            [MinLength(4, ErrorMessage = "El campo debe tener minimo 4 caracteres")]
            [MaxLength(10)]
            [Display(Name = "Codigo de Alumno(3 digitos)")]

            public String Codigo { get; set; }
            [Required(ErrorMessage = "El campo Alumno no debe estar vacio")]
            [MaxLength(25)]
            [Display(Name = "Nombre de Alumno")]
            public String Nombre { get; set; }
            [Required]
            public bool Activo { get; set; }


        }
    }
