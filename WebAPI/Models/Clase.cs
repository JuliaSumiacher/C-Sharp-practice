using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Clase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? ProfesorId { get; set; }
        public int? ColegioId { get; set; }    
        public Colegio Colegio { get; set; }
        public Profesor Profesor { get; set; }

    }
}
