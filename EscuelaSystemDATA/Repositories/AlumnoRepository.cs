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
    public void DeleteHabilitada()
    {
        var habilitadas = _db.Materias.Where(c => c.Habilitada == true).ToList();
        _db.SaveChanges();
    }
}

