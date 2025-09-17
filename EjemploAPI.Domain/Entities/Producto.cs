using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAPI.Domain.Entities
{
    [Table ("t_Producto")]
    public class Producto
    {
        [Key]
        [Column("")]
        public int IdProducto { get; set; }
        [Column("")]
        public string Nombre { get; set; }
        [Column("")]
        public string Description { get; set; }
        [Column("")]
        public string Precio { get; set; }
        [Column("")]
        public int Stock { get; set; }
        [Column("")]
        public DateTime FechaVencimiento { get; set; }
        [Column("")]
        public bool Estado { get; set; }
    }
}
