using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp.Models
{
    public class Personas
    {
        public Guid Id { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Estado { get; set; }
    }
}
