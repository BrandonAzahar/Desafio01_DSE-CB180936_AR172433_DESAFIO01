using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace CB180936_AR172433_DESAFIO01.Models
{
    public class Banco : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'Banco' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'CB180936_AR172433_DESAFIO01.Models.Banco' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'Banco'  en el archivo de configuración de la aplicación.
        public Banco()
            : base("name=Banco")
        {
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.


        public virtual DbSet<Cliente> Cliente { get; set; }

        public virtual DbSet<CuentaBancaria> CuentaBancaria { get; set; }

        public virtual DbSet<TipoTransaccion> TipoTransaccion { get; set; }

        public virtual DbSet<TipoCuentaBancaria> TipoCuentaBancaria { get; set; }

        public virtual DbSet<Transacciones> Transacciones { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }








        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}