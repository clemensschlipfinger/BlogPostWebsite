using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Model.Entities;

[Table("USER")]
public class User : IdentityUser
{
    [Required, StringLength(100)]
    [Column("FIRSTNAME")]
    public string FirstName { get; set; }
    
    [Required, StringLength(100)]
    [Column("LASTNAME")]
    public string LastName { get; set; }
}