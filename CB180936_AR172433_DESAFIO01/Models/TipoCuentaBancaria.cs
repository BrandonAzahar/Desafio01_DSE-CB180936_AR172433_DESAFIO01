using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace CB180936_AR172433_DESAFIO01.Models
{
    public partial class TipoCuentaBancaria
    {

        [Key]

        public int id { get; set; }



        public Nullable<bool> Active
        {
            get;
            set;
        }
        public string ISActive
        {
            get
            {
                return (bool)this.Active ? "Activo" : "No Activo";
            }
        }








        public virtual CuentaBancaria tipoCuentaBancaria { get; set; }


    }
}