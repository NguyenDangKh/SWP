using System.ComponentModel.DataAnnotations;

namespace DIAMOND.Models
{
    public class User
    {
        [Key]
        [Required]
        public int userID { get; set; }
        public string? username { get; set; }
        public string password { get; set; }
        public string? email { get; set; }
        public string? fullName { get; set; }
        public bool? status { get; set; }
        public int roleID {  get; set; }

        public virtual Role role { get; set;}
    }
}
