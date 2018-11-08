using System;
namespace prueba33.Models
{
    public class Empresa
    {

        public int IdEmpresa { get; private set; }
        public Rubro Rubro { get;  set; }
        public string Nombre { get;  set; }

        public Empresa(string Nombre, Rubro Rubro)
        {
            this.Rubro = Rubro;
            this.Nombre = Nombre;
        }
    }
}
