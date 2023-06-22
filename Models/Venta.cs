using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Entregable.Models
{
    public class Venta
    {
        public int id { get; set; }
        public string comentarios { get; set; }

        public Venta()
        {
            id = 0;
            comentarios = string.Empty;
        }
    }
}
