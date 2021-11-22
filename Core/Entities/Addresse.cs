using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Addresse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Streed { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode {get; set; }

        [Required]
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}