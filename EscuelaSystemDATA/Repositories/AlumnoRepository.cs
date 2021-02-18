using EscuelaSystem.Data.Interfaces;
using EscuelaSystemDATA;
using EscuelaSystemDATA.Interfaces;
using EscuelaSystemModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EscuelaSystemDATA.Repositories
{
}
public class AlumnoRepository : Repository<Alumno>, IAlumnoRepository
{
    public readonly ApplicationDbContext _db;
    public AlumnoRepository(ApplicationDbContext db) : base(db)
    {

    }
    public void Activo()
    {
        var activos = _db.Alumnos.Where(c => c.Activo == true).ToList();
        _db.RemoveRange(activos);
        _db.SaveChanges();
    }
}

