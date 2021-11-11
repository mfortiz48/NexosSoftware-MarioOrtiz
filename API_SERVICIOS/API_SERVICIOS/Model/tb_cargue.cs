using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //vrs.mfortiz 
using System.ComponentModel.DataAnnotations.Schema; // vrs.mfortiz

namespace API_SERVICIOS.Model
{
    public class tb_cargue
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long cliente_id { get; set; }
        public string cargue_anio { get; set; }
        public string cargue_mes { get; set; }
        public string cargue_consecutivo { get; set; }
        public string cargue_ciudad { get; set; }
        public string cargue_cod_vendedor { get; set; }
        public string cargue_cod_postal { get; set; }
        public string cargue_factura { get; set; }
        public string cargue_rer_armado { get; set; }
        public string cargue_apr_cartera { get; set; }
        public string cargue_pago { get; set; }
        public string cargue_fec_pago { get; set; }
        public string cargue_cta_cliente { get; set; }
        public string cargue_ref_pago { get; set; }
        public string cargue_email { get; set; }
        public string cargue_nombre { get; set; }
        public string cargue_cedula { get; set; }
        public string cargue_direccion { get; set; }
        public string cargue_barrio { get; set; }
        public string cargue_tel_fijo { get; set; }
        public string cargue_tel_mov { get; set; }
        public string cargue_equipo { get; set; }
        public string cargue_serv_solic { get; set; }
        public string cargue_incidencia { get; set; }
        public string cargue_cod_servicio { get; set; }
        public string cargue_lugar_compra { get; set; }
        public string cargue_fec_compra { get; set; }
        public string cargue_fec_reporte { get; set; }
        public string cargue_fec_atencion { get; set; }
        public string cargue_est_orden { get; set; }
        public string cargue_tecnico { get; set; }
        public string cargue_observaciones { get; set; }
        public string cargue_carta_garantia { get; set; }
        public string cargue_factura_2 { get; set; }
    }
}
