using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App_Lavacar.Models
{
    public class LavaCar
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Administracion administracion { get; set; }

        [Required]
        public Cliente cliente { get; set; }


        [Required]
        public Vehiculo vehiculo { get; set; }


        [Display(Name ="Lista de Servicios")]
        public List<Servicio> ListaServicios { get; set; }
    }
}
