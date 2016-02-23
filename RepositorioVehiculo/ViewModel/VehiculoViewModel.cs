using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseRepositorio.ViewModel;
using RepositorioVehiculo.Model;

namespace RepositorioVehiculo.ViewModel
{
    public class VehiculoViewModel:IViewModel<Vehiculo>
    {

        public int Id { get; set; }
        public int Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Matricula { get; set; }
        public decimal Precio { get; set; }


        public Vehiculo ToBaseDatos()
        {
            return new Vehiculo()
            {
                Id = Id,
                Tipo = Tipo,
                Marca = Marca,
                Modelo = Modelo,
                Matricula = Matricula,
                Precio = Precio,
            };
        }

        public void FromBaseDatos(Vehiculo modelo)
        {


            Id = modelo.Id;
            Tipo = modelo.Tipo;
            Marca = modelo.Marca;
            Modelo = modelo.Modelo;
            Matricula = modelo.Matricula;
            Precio = modelo.Precio;

        }

        public void UpdateBaseDatos(Vehiculo modelo)
        {
            modelo.Id = Id;
            modelo.Tipo = Tipo;
            modelo.Marca = Marca;
            modelo.Modelo = Modelo;
            modelo.Matricula = Matricula;
            modelo.Precio = Precio;
        }

        public object[] GetKeys()
        {
            return new object[] {Id};
        }
    }

}

