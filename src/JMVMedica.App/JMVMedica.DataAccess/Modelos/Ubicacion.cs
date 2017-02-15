using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMVMedica.DataAccess.Modelos
{
    public class Ubicacion : ModeloBase
    {
        public int UbicacionId { get; set; }
        public string Descripcion { get; set; }
        public string Estante { get; set; }
        public short Tramo { get; set; }
        public short Celda { get; set; }

        public virtual ICollection<Medicamento> Medicamentos { get; set; }
    }
}
