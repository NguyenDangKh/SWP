using System.ComponentModel.DataAnnotations;

namespace DIAMOND.Models
{
    public class Role
    {
        [Key]
        [Required]
        public int roleID { get; set; }
        public string? roleName { get; set; }
    }
}
