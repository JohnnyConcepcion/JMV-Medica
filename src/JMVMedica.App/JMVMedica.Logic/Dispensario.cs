using JMVMedica.DataAccess.Contexto;
using JMVMedica.DataAccess.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMVMedica.Logic
{
    public class Dispensario
    {
        private JMVContexto _contexto;
        public Dispensario()
        {
            _contexto = new JMVContexto();
        }

        #region TipoFarmaco
        public void InsertarTipoFarmaco(string descripcion, bool estado = true)
        {
            this._contexto.TipoFarmacos.Add(new TipoFarmaco()
            {
                Descripcion = descripcion,
                Estado = estado
            });
            this._contexto.SaveChanges();
        }

        public void EditarTipoFarmaco(int tipoFarmacoId, string descripcion, bool estado = true)
        {
            var tipoFarmaco = this._contexto.TipoFarmacos.Find(tipoFarmacoId);
            tipoFarmaco.Descripcion = descripcion;
            tipoFarmaco.Estado = estado;

            this._contexto.SaveChanges();
        }

        public void BorrarTipoFarmaco(int tipoFarmaco)
        {
            var tf = this._contexto.TipoFarmacos.Find(tipoFarmaco);
            tf.Estado = false;
            this._contexto.SaveChanges();
        }

        public IEnumerable<dynamic> CargarTipoFarmacos()
        {
            return this._contexto.TipoFarmacos.Where(x => x.Estado).ToArray();

        }
        #endregion

        #region Medicamentos
        public void InsertarMedicamento(string descripcion, int tipoFarmacoId, int marcaId, int ubicacionId, string dosis, bool estado = true)
        {
            this._contexto.Medicamentos.Add(new Medicamento()
            {
                Descripcion = descripcion,
                TipoFarmacoId = tipoFarmacoId,
                MarcaId = marcaId,
                UbicacionId = ubicacionId,
                Dosis = dosis,
                Estado = estado
            });
            this._contexto.SaveChanges();
        }

        public void EditarMedicamento(int medicamentoId,string descripcion,int tipoFarmacoId, int marcaId, int ubicacionId, string dosis, bool estado = true)
        {
            var medicamento = this._contexto.Medicamentos.Find(medicamentoId);
            medicamento.Descripcion = descripcion;
            medicamento.TipoFarmacoId = tipoFarmacoId;
            medicamento.MarcaId = marcaId;
            medicamento.UbicacionId = ubicacionId;
            medicamento.Dosis = dosis;
            medicamento.Estado = estado;

            this._contexto.SaveChanges();
        }

        public void BorrarMedicamento(int medicamentoId)
        {
            var medicamento = this._contexto.Medicamentos.Find(medicamentoId);
            medicamento.Estado = false;

            this._contexto.SaveChanges();
        }

        public IEnumerable<dynamic> CargarMedicamentos()
        {
            return this._contexto.Medicamentos.ToArray();
        }
        #endregion
    }
}
