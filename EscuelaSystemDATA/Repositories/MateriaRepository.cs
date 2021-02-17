using EscuelaSystemDATA.Interfaces;
using EscuelaSystemModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EscuelaSystemDATA.Repositories
{
    public class MateriaRepository : Repository<Materia>, IMateriaRepository
    {
        public readonly ApplicationDbContext _db;
        public MateriaRepository(ApplicationDbContext db) : base(db)
        {

        }
        public void DeleteHabilitada()
        {
            var habilitadas = _db.Alumnos.ToList();
            _db.SaveChanges();
        }
    }
}
