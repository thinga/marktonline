using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    [Table("UserPhotos")]
    public class UserPhoto
    {
        public int Id {get; set;}
        public string Url { get; set; }

        public bool IsMain { get; set; }
        public string PublicId { get; set; }

    }
}