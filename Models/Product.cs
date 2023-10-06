using System.ComponentModel.DataAnnotations;

namespace BlazingShop.Models
{
    public class Product
    {
        [Key]
        [Required(ErrorMessage = "O Id é obrigatório")]
        public int Id { get; set; }
        [Required(ErrorMessage = "O Nome é obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Este campo deve conter entre 3 e 100 caracteres")]
        public string Title { get; set; } = string.Empty;
        [Required(ErrorMessage = "O Preço é obrigatório")]
        [DataType(DataType.Currency)]
        [Range(0, 9999, ErrorMessage = "Preço deve estar entre 0 e 9999")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "O Categoria é obrigatório")]
        [Range(0, 9999, ErrorMessage = "Categoria deve estar entre 1 e 9999")]
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
