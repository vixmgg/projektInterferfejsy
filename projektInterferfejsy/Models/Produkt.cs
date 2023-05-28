using System.ComponentModel.DataAnnotations;

namespace projektInterferfejsy.Models
{
    public class Produkt
    {

        [Key]
        public int Id { get; set; }
        public string? Nazwa { get; set; }
        public int? Kalorie { get; set; }
        public int? Bialko { get; set; }
        public int? Weglowodany { get; set; }
        public int? Tluszcze { get; set; }
    }
}
