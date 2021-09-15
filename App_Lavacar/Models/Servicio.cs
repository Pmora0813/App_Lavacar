using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App_Lavacar.Models
{
    public class Servicio
    {
        [Key]
        public  int Id { get; set; }

        [Required]
        [Display(Name ="Descripción del Servicio")]
        public string Descripcion { get; set; }

        [Required]
        [Display(Name ="Precio del Servicio")]
        public double Precio { get; set; }
    }
}
