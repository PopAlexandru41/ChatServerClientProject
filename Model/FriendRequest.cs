using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class FriendRequest
    {
        [Key]
        public Guid IdFriendRequest { get; set; }
        [Required]
        public DateTime DateTimeWhenRequestWasCreated { get; set; }
        [Required]
        [ForeignKey("User")]
        public Guid IdFromUser { get; set; }
        [Required, ForeignKey("User")]
        public Guid IdToUser { get; set; }
    }

}
