using System.ComponentModel.DataAnnotations;

namespace ManagerLabs.Models;

public class User
{
    [Key]
    public int UserId { get; set; }
    [Required]
    [StringLength(50)]
    public string  Name { get; set; }
    [Required]
    [StringLength(20)]
    public string Password { get; set; }
    [Required]
    public int AccessLevel { get; set; }

}
