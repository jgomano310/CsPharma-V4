using DAL.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Contexto: DbContext
    {
        
            public Contexto(DbContextOptions<Contexto> options)
                : base(options)
            { }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.UseSerialColumns();
            }

            public DbSet<Tdc_tch_estado_pedidos> EstadoPedidos { get; set; }
            public DbSet<Tdc_cat_lineas_distribucion> LineasDistribucion { get; set; }
            public DbSet<tdc_cat_estados_envio_pedido> EstadosEnvioPedido { get; set; }
            public DbSet<Tdc_cat_estados_pago_pedido> EstadosPagoPedido { get; set; }
            public DbSet<tdc_cat_estados_devolucion_pedido> EstadosDevolucionPedido { get; set; }
        }
    }
