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
    [Table("Tdc_cat_estados_envio_pedido", Schema = "dwh_torrecontrol")]
    public class tdc_cat_estados_envio_pedido
    {
        [Column("Md_uuid")]
        [Display(Name = "Md_uuid")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Md_uuid { get; set; }

        [Required]
        [Column("Md_date")]
        [Display(Name = "Md_date")]
        public DateTime Md_date { get; set; }
        

        [Key]
        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Column("Cod_estado_envio")]
        [Display(Name = "Cod_estado_envio")]
        public string Cod_estado_envio { get; set; }

        
        [Column("Des_estado_envio")]
        [Display(Name = "Des_estado_envio")]
        public string? Des_estado_envio { get; set; }

   

        [InverseProperty("EstadoEnvio")]
        public virtual List<Tdc_tch_estado_pedidos>? ListaEstadoPedidos { get; set; }
    }
}
