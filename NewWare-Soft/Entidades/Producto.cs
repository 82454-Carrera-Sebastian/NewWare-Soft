using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWare_Soft.Entidades
{
    class Producto
    {
        private string denominacion;
        private string descripcion;
        private DateTime fechaFinalizacion;
        private int precio;
        public Producto(string denominacion, string descripcion, DateTime fechaFinalizacion, int precio) 
        {
            this.denominacion = denominacion;
            this.descripcion = descripcion;
            this.fechaFinalizacion = fechaFinalizacion;
            this.precio = precio;
        }
        public Producto() { }
        public string Denominacion
        {
            get => denominacion;
            set => denominacion = value;
        }
        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
        public DateTime FechaDeFinalizacion
        {
            get => fechaFinalizacion;
            set => fechaFinalizacion = value;
        }
        public int Precio
        {
            get => precio;
            set => precio = value;
        }
    }
}
