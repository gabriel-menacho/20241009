using PreGrado.Models;

namespace PreGrado.Repositories
{
    public class ImplEstudiante1Repository : IEstudiante1Repository
    {
        public Estudiante1 GetEstudianteById(int id)
        {
            return new Estudiante1
            {
                id = 100,
                name = "Pepe Perales",
                carrera = "Contabilidad2",
                email = "pepe2@gmail.com"
            };
        }

        public IEnumerable<Estudiante1> GetEstudiantes()
        {
            var estudiantes = new List<Estudiante1> {
                new Estudiante1{
                    id=1,
                    name="Pepe1 Perales",
                    carrera="Contabilidad1",
                    email="pepe1@gmail.com"
                },
                new Estudiante1{
                    id=2,
                    name="Pepe2 Perales",
                    carrera="Contabilidad2",
                    email="pepe2@gmail.com"
                },
                new Estudiante1{
                    id=3,
                    name="Pepe3 Perales",
                    carrera="Contabilidad3",
                    email="pepe3@gmail.com"
                },
                new Estudiante1{
                    id=4,
                    name="Pepe4 Perales",
                    carrera="Contabilidad4",
                    email="pepe4@gmail.com"
                },
            };
            return estudiantes;
        }
    }
}
