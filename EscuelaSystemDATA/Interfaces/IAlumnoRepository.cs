using System;
using System.Collections.Generic;
using System.Text;
using EscuelaSystemDATA.Interfaces;
using EscuelaSystemModels;

namespace EscuelaSystem.Data.Interfaces
{
    public interface IAlumnoRepository : IRepository<Alumno>
    {
        void Activo();
    }
}