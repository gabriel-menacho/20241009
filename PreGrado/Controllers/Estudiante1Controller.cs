using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PreGrado.Models;
using PreGrado.Repositories;

namespace PreGrado.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/estudiante")]
    [ApiController]
    public class Estudiante1Controller : ControllerBase
    {
        //private readonly ImplEstudiante1Repository repo = new ImplEstudiante1Repository();

        private readonly IEstudiante1Repository repo;

        public Estudiante1Controller(IEstudiante1Repository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Estudiante1>> GetEstudiantes()
        {
            var ests = repo.GetEstudiantes();
            return Ok(ests); // 200
        }

        [HttpGet("{id}")]
        public ActionResult<Estudiante1> GetEstudianteById(int id)
        {
            var est = repo.GetEstudianteById(id);
            return Ok(est); // 200
        }
    }
}
