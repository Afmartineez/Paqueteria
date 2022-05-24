using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Paqueteria.Models.dbModels
{
    public partial class Incidencia
    {
        [Key]
        public int IdIncidencia { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Column("Id_pedido")]
        public int IdPedido { get; set; }

        [ForeignKey(nameof(IdPedido))]
        [InverseProperty(nameof(Pedido.Incidencia))]
        public virtual Pedido IdPedidoNavigation { get; set; }
    }
}
