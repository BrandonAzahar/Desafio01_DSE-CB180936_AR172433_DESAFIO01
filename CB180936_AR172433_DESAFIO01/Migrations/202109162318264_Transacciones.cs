namespace CB180936_AR172433_DESAFIO01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Transacciones : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Nombres = c.String(nullable: false, maxLength: 200),
                        PrimerApellido = c.String(maxLength: 100),
                        SegundoApellido = c.String(maxLength: 100),
                        Telefono = c.String(nullable: false, maxLength: 8),
                        Correo = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.CuentaBancaria",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Moneda = c.String(maxLength: 100),
                        Tipo = c.String(maxLength: 100),
                        IdCliente_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Cliente", t => t.IdCliente_id)
                .Index(t => t.IdCliente_id);
            
            CreateTable(
                "dbo.TipoCuentaBancaria",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Active = c.Boolean(),
                        tipoCuentaBancaria_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.CuentaBancaria", t => t.tipoCuentaBancaria_id)
                .Index(t => t.tipoCuentaBancaria_id);
            
            CreateTable(
                "dbo.TipoTransaccion",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tipoTransaccion = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Transacciones",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Monto = c.Single(nullable: false),
                        Active = c.Boolean(),
                        FechaTransaccion = c.DateTime(nullable: false),
                        FechaAplicacion = c.DateTime(nullable: false),
                        IdCuentaBancaria_id = c.Int(),
                        tipoTransaccion_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.CuentaBancaria", t => t.IdCuentaBancaria_id)
                .ForeignKey("dbo.TipoTransaccion", t => t.tipoTransaccion_id)
                .Index(t => t.IdCuentaBancaria_id)
                .Index(t => t.tipoTransaccion_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transacciones", "tipoTransaccion_id", "dbo.TipoTransaccion");
            DropForeignKey("dbo.Transacciones", "IdCuentaBancaria_id", "dbo.CuentaBancaria");
            DropForeignKey("dbo.TipoCuentaBancaria", "tipoCuentaBancaria_id", "dbo.CuentaBancaria");
            DropForeignKey("dbo.CuentaBancaria", "IdCliente_id", "dbo.Cliente");
            DropIndex("dbo.Transacciones", new[] { "tipoTransaccion_id" });
            DropIndex("dbo.Transacciones", new[] { "IdCuentaBancaria_id" });
            DropIndex("dbo.TipoCuentaBancaria", new[] { "tipoCuentaBancaria_id" });
            DropIndex("dbo.CuentaBancaria", new[] { "IdCliente_id" });
            DropTable("dbo.Transacciones");
            DropTable("dbo.TipoTransaccion");
            DropTable("dbo.TipoCuentaBancaria");
            DropTable("dbo.CuentaBancaria");
            DropTable("dbo.Cliente");
        }
    }
}
