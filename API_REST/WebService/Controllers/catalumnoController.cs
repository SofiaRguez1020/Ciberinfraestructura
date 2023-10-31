using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using WebService.DataAccess;
using WebService.Models;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    public class catalumnoController : ControllerBase
    {
        private readonly IDataAccessProvider _provider;

        public catalumnoController(IDataAccessProvider dataAccessProvider)
        {
            _provider = dataAccessProvider;
        }

        [HttpGet]
        public IEnumerable<catalumno> Get()
        {
            return _provider.GetAlumnos();
        }
        [HttpGet("{id}")]
        public catalumno GetCatalumno(int id)
        {
            return _provider.GetAlumno(id);
        }
        [HttpPost]
        public void Postcatalumno(catalumno catalumnoPost)
        {
            _provider.Postcatalumno(catalumnoPost);
        }
    }
}
