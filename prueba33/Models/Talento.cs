using System;
using System.Collections.Generic;
namespace prueba33.Models
{
    public class Talento 
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Nacimiento { get; set; }
        public Rubro Rubro { get; set; } 
        public CurriculumVitae Curriculum { get; set; }

        public int Id { get; private set; }
        public string Username { get; set; }
        public string Password{ get; set; }
        public string Email { get; set; }
        

        public Talento(string Username, string Password, string Email, DateTime Nacimiento, string Nombre, string Apellido, Rubro Rubro)
        {
            this.Nacimiento = Nacimiento;
            this.Username = Username;
            this.Password = Password;
            this.Email = Email;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Rubro = Rubro;


        }



    }
}
