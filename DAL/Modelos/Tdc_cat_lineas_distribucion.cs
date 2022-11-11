using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL.Modelos
{
    [Table("Tdc_cat_lineas_distribucion", Schema = "dwh_torrecontrol")]
    public class Tdc_cat_lineas_distribucion
    {

        [Required]
        [Column("Md_uuid")]
        [Display(Name = "Md_uuid")]
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
        [Column("Cod_linea")]
        [Display(Name = "Cod_linea")]
        public string Cod_linea { get; set; }

        [Required]
        [Column("Cod_provincia")]
        [Display(Name = "Cod_provincia")]
        public string Cod_provincia { get; set; }

        [Required]
        [Column("Cod_municipio")]
        [Display(Name = "Cod_municipio")]
        public string Cod_municipio { get; set; }

        [Required]
        [Column("Cod_barrio")]
        [Display(Name = "Cod_barrio")]
        public string Cod_barrio { get; set; }

        

        [InverseProperty("LineaDistribucion")]
        public virtual List<Tdc_tch_estado_pedidos>? ListaEstadoPedidos { get; set; }
    }
}

