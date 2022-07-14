using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    [Index(nameof(Name),IsUnique =true)]
    public class User
    {
        [Key]
        public Guid IdUser { get; set; }
        [Required]
        public string Name { get; set; }
        [Required] 
        public string Password { get; set; }
        [Required]
        [DefaultValue(0)]
        [Range(0, int.MaxValue)]
        public int NrOfFriendRequests { get; set; } = 0;
    }
}
