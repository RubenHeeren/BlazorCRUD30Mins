using System.ComponentModel.DataAnnotations;

namespace BlazorCRUD10Mins.Data
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(128)]
        public string Title { get; set; }

        [Required]
        [MaxLength(4096)]
        public string Content { get; set; }
    }
}
