using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMVMedica.DataAccess.Modelos
{
    public class TipoFarmaco : ModeloBase
    {
        public int TipoFarmacoId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Medicamento> Medicamentos { get; set; }
    }
}
