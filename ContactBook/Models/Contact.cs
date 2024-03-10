using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ContactBook.Models
{
    public class Contact
    {
        public int Id { get; set; }

        // Imię i nazwisko kontaktu
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        // Numer telefonu kontaktu
        [Required]
        [StringLength(20)]
        public string TelephoneNumber { get; set; }

        // Miasto zamieszkania kontaktu
        [Required]
        [StringLength(50)]
        public string City { get; set; }
    }
}
