using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name="Ürün Id")]
        public int ProductId { get; set; }

        [Display(Name = "Adı")]
        public string? Name { get; set; }

        [Display(Name = "Fiyatı")]
        public decimal Price { get; set; }

        [Display(Name = "Resmi")]
        public string Image { get; set; } = string.Empty;

        [Display(Name = "Aktif mi?")]
        public bool IsActive { get; set; }
        [Display(Name = "Kategorisi")]

        public int CategoryId { get; set; }
    }
}
