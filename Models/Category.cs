using System.ComponentModel.DataAnnotations;

namespace BlazingShop.Models
{
    public class Category
    {
        [Key]
        [Required(ErrorMessage = "O Id é obrigatório")]
        public int Id { get; set; }
        [Required(ErrorMessage = "O Nome e obrigatório")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Este campo deve conter entre 3 e 40 caracteres")]
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
