using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Paqueteria.Models.dbModels
{
    public partial class Pedido
    {
        public Pedido()
        {
            Incidencia = new HashSet<Incidencia>();
        }

        [Key]
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
        [Column("Id_vendedor")]
        public int IdVendedor { get; set; }
        [Column("Id_repartidor")]
        public int IdRepartidor { get; set; }
        public int Estatus { get; set; }
        [ForeignKey(nameof(IdVendedor))]
        [InverseProperty(nameof(ApplicationUser.Pedidos))]
        public virtual ApplicationUser IdVendedorNavigation { get; set; }
        

        [ForeignKey(nameof(Estatus))]
        [InverseProperty("Pedidos")]
        public virtual Estatus EstatusNavigation { get; set; }
        [ForeignKey(nameof(IdRepartidor))]
        [InverseProperty(nameof(Repartidore.Pedidos))]
        public virtual Repartidore IdRepartidorNavigation { get; set; }
        [ForeignKey(nameof(Municipio))]
        [InverseProperty("Pedidos")]
        public virtual Municipio MunicipioNavigation { get; set; }
        [InverseProperty("IdPedidoNavigation")]
        public virtual ICollection<Incidencia> Incidencia { get; set; }
    }
}
