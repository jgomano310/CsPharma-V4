using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL.Modelos
{
    [Table("Tdc_cat_estados_pago_pedido", Schema = "dwh_torrecontrol")]
    public class Tdc_cat_estados_pago_pedido
    {

        

        
        [Key]
        [Column("Md_uuid")]
        [Display(Name = "Md_uuid")]
        public string Md_uuid { get; set; }

        [Required]
        [Column("Md_date")]
        [Display(Name = "Md_date")]
        public DateTime Md_date { get; set; }


        

        [Required]
        [Column("Cod_estado_pago")]
        [Display(Name = "Cod_estado_pago")]
        public string Cod_estado_pago { get; set; }

       
        [Column("Des_estado_pago")]
        [Display(Name = "Des_estado_pago")]
        public string? Des_estado_pago { get; set; }

        

        [InverseProperty("EstadoPago")]
        public virtual List<Tdc_tch_estado_pedidos>? ListaEstadoPedidos { get; set; }
    }
}
