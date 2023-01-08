using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities; 

[Table("POSTS_BT")]
public class APost {

    [Column("POST_ID")]
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [Column("BODY",TypeName = "MEDIUMTEXT")]
    public string Body { get; set; }
    
    [Required]
    [Column("LAST_EDITED_AT")]
    public DateTime LastEditedAt { get; set; }

    [Required]
    [Column("AUTHOR_ID")]
    public string AuthorId { get; set; }

    public virtual User Author { get; set; }
    
    public virtual List<Comment> ChildComments { get; set; } 

}