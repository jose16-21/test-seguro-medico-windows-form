using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp.Models
{
    public class Proveedor
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Nit { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Estado { get; set; }
    }
}
