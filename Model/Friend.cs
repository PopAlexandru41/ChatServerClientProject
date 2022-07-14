using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Friend
    {
        [Key]
        public Guid IdFriends { get; set; }
        [Required]
        [ForeignKey("User")]
        public Guid IdUser1 { get; set; }
        [Required]
        [ForeignKey("User")]
        public Guid IdUser2 { get; set; }
        [Required]
        public DateTime DateTimeWhenRelacionWasCreated { get; set; }
    }
}
