using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using WebService.Models;

namespace WebService.DataAccess
{
    public class DataAccessProvider : IDataAccessProvider
    {
        private readonly PostgreSqlContext _context;

        public DataAccessProvider(PostgreSqlContext context)
        {
            _context = context;
        }
        public List<catalumno> GetAlumnos()
        {
            return _context.catalumno.ToList();
        }
        public catalumno GetAlumno(int id)
        {
            var idAlumno = _context.Find<catalumno>(id);

            return idAlumno;
        }
        public void Postcatalumno(catalumno catalumnoPost)
        {
            var catalumnoTemp = new catalumno
            {
                id = catalumnoPost.id,
                nombre = catalumnoPost.nombre
            };
            _context.catalumno.Add(catalumnoTemp);
            _context.SaveChangesAsync();
        }
    }
}
