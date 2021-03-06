using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeMugApp.Dtos
{
    public class ProductUpdateRequestDto
    {
        [Column(TypeName="guid")]
        public Guid Id { get; set; }
        [Required]
        [Column(TypeName="nvarchar(100)")]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [Column(TypeName="decimal")]
        public decimal Price { get; set; }
    }
}