using EscuelaSystemModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EscuelaSystemDATA.Interfaces
{
    public interface IMateriaRepository : IRepository<Materia>
    {
        void DeleteHabilitada();
    }
}
