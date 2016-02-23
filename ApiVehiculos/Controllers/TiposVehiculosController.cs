using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using BaseRepositorio.Repositorio;
using Microsoft.Practices.Unity;
using RepositorioVehiculo.Model;
using RepositorioVehiculo.ViewModel;

namespace ApiVehiculos.Controllers

    
{
        [EnableCors(origins: "*", headers: "*", methods: "*")]

        public class TiposVehiculosController : ApiController


    {
        [Dependency]  // va a Unity y él se encarga de gestionarla //

        public IRepositorio<TipoVehiculo, TipoVehiculoViewModel> Repositorio { get; set; }

        public ICollection<TipoVehiculoViewModel> Get()
        {
            return Repositorio.Get();
        }

        [ResponseType(typeof (TipoVehiculoViewModel))]   //ESTO SIRVE PARA DEVOLVER ERRORES TIPO 100, 200, 400... //

        public IHttpActionResult Get(int id)
        {
            var data = Repositorio.Get(id);
            if (data == null)
                return NotFound();
            return Ok(data);
        }

        [HttpPost] //ESTO SIRVE PARA CREAR NUEVOS OBJETOS DE TIPO POST //
        [ResponseType(typeof (TipoVehiculoViewModel))]

        public IHttpActionResult NuevoTipo(TipoVehiculoViewModel model)
        {
            var data = Repositorio.Add(model);
            if (data == null)
            {


                return BadRequest("Error al crear el objeto");
            }

            model.Id = data.Id;
            return Created("ApiVehiculos",model);

        }



    }
}
