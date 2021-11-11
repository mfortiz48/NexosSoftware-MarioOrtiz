using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; 



namespace API_SERVICIOS.Model
{
    public class _DbContext:DbContext
    {


        public _DbContext(DbContextOptions<_DbContext> options) : base(options)
        {
        }

        public DbSet<tb_clientes> Tb_Clientes { get; set; }
        public DbSet<tb_cargue> Tb_Cargues { get; set; }
        public DbSet<tb_direccionCliente> Tb_direccionCliente { get; set; }
        public DbSet<tb_servicio> Tb_servicio { get; set; }
        public DbSet<tb_servicio_tpo> Tb_servicio_tpo { get; set; }
        public DbSet<tb_servicioDetalle> Tb_servicioDetalle { get; set; }
        public DbSet<tb_tecnico> Tb_tecnico { get; set; }


    }




}
