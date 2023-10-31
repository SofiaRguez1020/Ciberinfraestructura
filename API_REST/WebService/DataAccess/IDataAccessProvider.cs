using System.Collections.Generic;
using WebService.Models;

namespace WebService.DataAccess
{
    /// <summary>
    /// IZETTER 25/10/2023
    /// INTERFACE DE ACCESO A MÉTODOS DE PERSISTENCIA
    /// </summary>
    public interface IDataAccessProvider
    {
        List<catalumno> GetAlumnos();
        catalumno GetAlumno(int id);
        void Postcatalumno(catalumno catalumnoPost);
    }
}
