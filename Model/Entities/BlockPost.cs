using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities; 

[Table("BLOGPOSTS")]
public class BlogPost : APost {

    [Required, StringLength(225)]
    [Column("TITLE")]
    public string Title { get; set; }
    
    [Required]
    [Column("IS_PUBLISHED")]
    public bool IsPublished { get; set; }
}