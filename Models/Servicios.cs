using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp.Models
{
    public class Servicio
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Guid ProveedorId { get; set; }

    }
}
