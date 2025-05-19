using System.Collections.Generic;

namespace WebApplication.Models
{
    public class Clase
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }

        public int ColegioId { get; set; }
        public Colegio? Colegio { get; set; }

        public List<Alumno>? Alumnos { get; set; }
        public List<Profesor>? Profesores { get; set; }
    }
}

