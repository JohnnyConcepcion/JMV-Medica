using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMVMedica.DataAccess.Modelos
{
    public class Visita : ModeloBase
    {
        public int VisitaId { get; set; }
        public int MedicoId { get; set; }
        public int PacienteId { get; set; }
        public int MedicamentoId { get; set; }
        public DateTime FechaVisita { get; set; }
        public string Sintomas { get; set; }
        public string Recomendaciones { get; set; }
    }
}
