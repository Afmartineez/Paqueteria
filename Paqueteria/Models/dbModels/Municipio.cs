using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Paqueteria.Models.dbModels
{
    public partial class Municipio
    {
        public Municipio()
        {
            Pedidos = new HashSet<Pedido>();
            Users = new HashSet<ApplicationUser>();
        }

        [Key]
        public int IdMunicipio { get; set; }
        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        [InverseProperty(nameof(ApplicationUser.MunicipioNavigation))]
        public virtual ICollection<ApplicationUser> Users { get; set; }

        [InverseProperty(nameof(Pedido.MunicipioNavigation))]
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
