using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace CB180936_AR172433_DESAFIO01.Models
{
    public partial class Transacciones
    {
        [Key]
       
        public int id { get; set; }

     
        public virtual TipoTransaccion tipoTransaccion { get; set; }


        public virtual CuentaBancaria IdCuentaBancaria { get; set; }



        [Range(1, 100.99)]
        [DataType(DataType.Currency)]
        public float Monto { get; set; }


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


        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]

        public DateTime FechaTransaccion { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]

        public DateTime FechaAplicacion { get; set; }





    }
}