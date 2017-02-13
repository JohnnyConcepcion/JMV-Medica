using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMVMedica.DataAccess.Modelos
{
    public class Medico : ModeloBase
    {
        public int MedicoId { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public TandaLabor TandaLabor { get; set; }
        public string Especialidad { get; set; }

        public virtual ICollection<Visita> Visitas { get; set; }
    }
}
