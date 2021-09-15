using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App_Lavacar.Models
{
    public class Vehiculo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(120)]
        public string Placa { get; set; }
            
        public string Marca { get; set; }

        [Display(Name ="Descripción")]
        public string Descripcion { get; set; }


    }
}
