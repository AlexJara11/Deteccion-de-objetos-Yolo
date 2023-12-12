using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamYolo.Model
{
    public class Object
    {
        public int Id { get; set; }
        public string ObjectName { get; set; }
        public byte[] ObjectImage { get; set; }
        public byte[] Imagenes { get; set; }
    }
}
