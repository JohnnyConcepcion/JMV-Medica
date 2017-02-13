using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMVMedica.DataAccess.Modelos
{
    public class Marca : ModeloBase
    {
        public int MarcaId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Medicamento> Medicamentos { get; set; }
    }
}
