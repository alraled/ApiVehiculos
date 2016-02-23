using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseRepositorio.Repositorio;
using Microsoft.Practices.Unity;
using RepositorioVehiculo.Model;
using RepositorioVehiculo.ViewModel;

namespace ApiVehiculos.App_Start
{
    public class Bootstraper
    {
        public static void Init(UnityContainer container)
        {
            container.RegisterType<DbContext, VehiculosDamaEntities>();
            container.RegisterType<IRepositorio<TipoVehiculo, TipoVehiculoViewModel>,
                RepositorioEntity<TipoVehiculo, TipoVehiculoViewModel>>();
            container.RegisterType<IRepositorio<Vehiculo, VehiculoViewModel>, 
                RepositorioEntity<Vehiculo, VehiculoViewModel>>();


        }
    
    }
}
