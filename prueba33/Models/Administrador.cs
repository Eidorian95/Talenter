using System;
using System.Collections.Generic;
namespace prueba33.Models
{
    public class Administrador : Empleado
    {
        public string RazonSocial { get; set; }
        public List<Empleado> Empleados { get; set; }
<<<<<<< HEAD

        public Administrador()
=======
        
        public Administrador(string RazonSocial)
>>>>>>> f564d49feeffc526e04f30337a2bc25ede12cd6f
        {
            this.RazonSocial = RazonSocial;
            Empleados = new List<Empleado>();
        }

        public Administrador(string RazonSocial, List<Empleado> Empleados) {
            this.RazonSocial = RazonSocial;
            this.Empleados = Empleados;
        }

        public void darAltaEmpleado(Empleado empleado) {
            Empleados.Add(empleado);
        }

        public void darBajaEmpleado(Empleado empleado) {
            Empleados.Remove(empleado);
        }

        public void verEmpleado(Empleado empleado){
            //TODO: Ver bien como hacer esto
            if(Empleados.Contains(empleado)) {
                //
            }
        }
    }
}
