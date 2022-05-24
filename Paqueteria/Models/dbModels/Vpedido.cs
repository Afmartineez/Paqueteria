using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Paqueteria.Models.dbModels
{
    [Keyless]
    public partial class Vpedido
    {
        public int IdPedido { get; set; }
        [Required]
        public string Descripcion { get; set; }
        public double Costo { get; set; }
        [Required]
        [StringLength(50)]
        public string Calle { get; set; }
        public int Numero { get; set; }
        [Required]
        [StringLength(50)]
        public string Colonia { get; set; }
        public int Municipio { get; set; }
        [Required]
        [StringLength(50)]
        public string DescMun { get; set; }
        [Column("Id_vendedor")]
        public int IdVendedor { get; set; }
        [Column("Id_repartidor")]
        public int IdRepartidor { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50)]
        public string Paterno { get; set; }
        [Required]
        [StringLength(50)]
        public string Materno { get; set; }
        public int Estatus { get; set; }
        [Required]
        [StringLength(50)]
        public string DescEst { get; set; }
    }
}
