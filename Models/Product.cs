using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name="Ürün Id")]
        public int ProductId { get; set; }


        [Display(Name = "Adı")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [StringLength(100)]
        public string? Name { get; set; }

        [Display(Name = "Fiyatı")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [Range(0,100000)]
        public decimal Price { get; set; }

        [Display(Name = "Resmi")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        public string Image { get; set; } = string.Empty;

        [Display(Name = "Aktif mi?")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        public bool IsActive { get; set; }

        [Display(Name = "Kategorisi")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        public int? CategoryId { get; set; }
    }
}
