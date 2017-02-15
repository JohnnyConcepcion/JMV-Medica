using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMVMedica.DataAccess.Modelos
{
    public class Medicamento : ModeloBase
    {
        public int MedicamentoId { get; set; }
        public string Descripcion { get; set; }
        public int TipoFarmacoId { get; set; }
        public int MarcaId { get; set; }
        public int UbicacionId { get; set; }
        public string Dosis { get; set; }

        public Marca Marca { get; set; }
        public TipoFarmaco TipoFarmaco { get; set; }
        public Ubicacion Ubicacion { get; set; }

        public virtual ICollection<Visita> Visitas { get; set; }
    }
}
