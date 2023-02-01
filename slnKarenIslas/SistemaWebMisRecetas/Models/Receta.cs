using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SistemaWebMisRecetas.Validations;

namespace SistemaWebMisRecetas.Models
{
    public class Receta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string Autor { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string Apellido { get; set;}

        [Required(ErrorMessage = "Campo obligatorio")]
        [EdadAttribute]
        public int Edad { get;set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [RegularExpression (@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage ="Debe ingresar un Email válido")]
        public string Email { get;set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [CategoriaAttribute]
        public string Categoria { get;set;}

        [Required(ErrorMessage = "Campo obligatorio")]
        [DataType(DataType.MultilineText)]
        [Column(TypeName = "varchar(1000)")]
        [StringLength(1000)]
        public string Ingredientes { get;set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [DataType(DataType.MultilineText)]
        [Column(TypeName = "varchar(2000)")]
        [StringLength(2000)]
        public string Instrucciones { get;set; }
    }
}
