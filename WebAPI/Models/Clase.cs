namespace WebAPI.Models
{
    public class Clase
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int IdProfesor { get; set; }
        public int IdColegio { get; set; }    
        public Colegio Colegio { get; set; } = null!;
        public Profesor Profesor { get; set; } = null!;

    }
}
