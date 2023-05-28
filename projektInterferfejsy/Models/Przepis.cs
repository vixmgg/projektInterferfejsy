using projektInterferfejsy.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projektInterferfejsy.Models
{
    public class Przepis
    {
        [Key]
        public int Id { get; set; }
        public string? Nazwa { get; set; }
        public string? Opis { get; set; }
        public int? CzasPrzygotowania { get; set; }
        public string? Trudnosc { get; set; }
        public ICollection<Produkt> Produkty { get; set; }
    }
}