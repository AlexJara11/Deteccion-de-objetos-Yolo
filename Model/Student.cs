using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamYolo.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Escuela { get; set; }
        public string course { get; set; }
        // Propiedades para la autenticación
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        // Relación muchos a muchos con Object a través de la tabla intermedia
        public virtual ICollection<StudentObjectHistory> StudentObjectHistories { get; set; }

    }
}
