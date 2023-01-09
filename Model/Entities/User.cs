using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
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

    [Required]
    [Column("DESCRIPTION"), DataType(DataType.Text)]
    public string Description { get; set; } = "I love to write about interesting topics.";
}