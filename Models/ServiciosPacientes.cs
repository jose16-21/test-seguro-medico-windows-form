using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp.Models
{
    public class ServicioPaciente
    {
        public Guid Id { get; set; }
        public Guid PacienteId { get; set; }
        public Guid ServicioId { get; set; }
        public DateTime FechaServicio { get; set; }


    }
}
