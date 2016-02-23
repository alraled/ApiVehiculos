using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseRepositorio.ViewModel;
using RepositorioVehiculo.Model;

namespace RepositorioVehiculo.ViewModel
{

public class TipoVehiculoViewModel:IViewModel<TipoVehiculo>
    {

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Id { get; set; }


        public TipoVehiculo ToBaseDatos()
        {
            return new TipoVehiculo()
            {
                Id = Id,
                Nombre = Nombre,
                Descripcion = Descripcion
            };
        }

        public void FromBaseDatos(TipoVehiculo modelo)
        {
            Id = modelo.Id;
            Nombre = modelo.Nombre;
            Descripcion = modelo.Descripcion;

        }

        public void UpdateBaseDatos(TipoVehiculo modelo)
        {
            modelo.Id = Id;
            modelo.Nombre = Nombre;
            modelo.Descripcion = Descripcion;
        }

        public object[] GetKeys()
        {
            return new object[] {Id};
        }
    }
}
