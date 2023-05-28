using RunGroopWebApp.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projektInterferfejsy.Models
{
    public class Dieta
    {
        [Key]
        public int Id { get; set; }
        public string? Nazwa { get; set; }
        public string? Opis { get; set; }
        public ICollection<Produkt> Produkty { get; set; }
    }
}