using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App_Lavacar.Models
{
    public class Cliente
    {   
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(120)]
        public string Nombre { get; set; }

        [Display(Name ="Teléfono")]
        public string Telefono { get; set; }

        [Display(Name ="Direccion de Correo")]
        public string Corre { get; set; }

<<<<<<< HEAD
        //Prueba
=======

>>>>>>> 7287f37715f3f8b07d3ba3a249c7486406984bda
    }
}
