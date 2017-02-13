using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMVMedica.DataAccess.Modelos
{
    public class Paciente : ModeloBase
    {
        public int PacienteId { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Carnet { get; set; }
        public TipoPaciente TipoPaciente { get; set; }

        public virtual ICollection<Visita> Visitas { get; set; }
    }
}
