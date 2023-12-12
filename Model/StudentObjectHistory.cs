using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamYolo.Model
{
    [Table("StudentObjectHistory", Schema = "dbo")]
    public class StudentObjectHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string TiempoUso { get; set; }
        public string Objetos { get; set; }

        // Propiedad de navegación a Student
        public virtual Student Student { get; set; }
    }
}
