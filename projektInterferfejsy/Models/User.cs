using System.ComponentModel.DataAnnotations;

namespace projektInterferfejsy.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string? Imie { get; set; }
        public string? Nazwisko { get; set; }
        public string? Email { get; set; }
        public string? Haslo { get; set; }
        public ICollection<Dieta> Diety { get; set; }
        public ICollection<Przepis> Przepisy { get; set; }
    }
}
