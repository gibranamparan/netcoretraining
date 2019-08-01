using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace training.entidades.Almacen
{
    public class Categoria
    {
        [Key]
        public int idCategoria { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 50 caracteres")]
        public int nombre { get; set; }

        [StringLength(256)]
        public int descripcion { get; set; }
        public bool condicion { get; set; }
    }
}
