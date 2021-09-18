using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;


namespace CB180936_AR172433_DESAFIO01.Models
{
    public partial class Cliente
    {

        [Key]

        public int id { get; set; }

        [StringLength(200)]

        [Required(ErrorMessage = "Campo nombres requerido")]
        public string Nombres { get; set; }




        [StringLength(100)]

        public string PrimerApellido { get; set; }





        [StringLength(100)]

        public string SegundoApellido { get; set; }

        [StringLength(8)]
        [Required(ErrorMessage = "Campo número telefono requerido")]


        public string Telefono { get; set; }






        [StringLength(100)]


        [EmailAddress(ErrorMessage = "El correo no cumple con el formato correcto")]

        public string Correo { get; set; }






    }
}