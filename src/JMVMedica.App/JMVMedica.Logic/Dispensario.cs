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

        public IEnumerable<TipoFarmaco> CargarTipoFarmacos()
        {
            return this._contexto.TipoFarmacos.Where(x => x.Estado).ToList();

        }
        #endregion
    }
}
