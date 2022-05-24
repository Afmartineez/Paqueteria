using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Paqueteria.Models.dbModels
{
    [Table("Estatus")]
    public partial class Estatus
    {
        public Estatus()
        {
            Pedidos = new HashSet<Pedido>();
        }

        [Key]
        public int IdEstatus { get; set; }
        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        [InverseProperty(nameof(Pedido.EstatusNavigation))]
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
