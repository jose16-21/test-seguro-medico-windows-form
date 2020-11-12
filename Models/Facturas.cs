using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp.Models
{
    public class Factura
    {
        public Guid Id { get; set; }
        public Guid PacienteId { get; set; }
        public DateTime FechaFactura { get; set; }
        public string Serie { get; set; }
        public string Numero { get; set; }
        public decimal Monto { get; set; }
        public int CantidadMedicamentos { get; set; }
    }
}
