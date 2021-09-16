using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App_Lavacar.Models
{
    public class Administracion
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nombre del Local")]
        public string NombreEmpresa { get; set; }

        [Required]
        public string Propietario { get; set; }

        [Display(Name ="Cédula")]
        public string Cedula { get; set; }

        public string Provincia { get; set; }

        public string Canton { get; set; }
        public string Distrito { get; set; }

        [Display(Name ="Dirección")]
        public string Direccion { get; set; }

        [Display(Name ="Teléfono")]
        public string Telefono { get; set; }

        public string Correo { get; set; }


    }
}
