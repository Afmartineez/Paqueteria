using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Paqueteria.Models.dbModels
{
    public partial class Repartidore
    {
        public Repartidore()
        {
            Pedidos = new HashSet<Pedido>();
        }

        [Key]
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
        [Required]
        [StringLength(12)]
        public string Telefono { get; set; }
        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }
        [Required]
        [StringLength(50)]
        public string Contraseña { get; set; }

        [InverseProperty(nameof(Pedido.IdRepartidorNavigation))]
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
