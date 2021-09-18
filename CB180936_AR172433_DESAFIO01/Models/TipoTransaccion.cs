using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace CB180936_AR172433_DESAFIO01.Models
{
    public partial class TipoTransaccion
    {
        [Key]

        public int id { get; set; }

        [StringLength(100)]

        public string tipoTransaccion { get; set; }





    }
}