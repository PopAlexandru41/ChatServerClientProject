using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Chat
    {
        [Key]
        public Guid IdChat { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public bool IsCreateDefault { get; set; }
        [Required]
        public DateTime LastMessageDate {get;set;}
    }
}
