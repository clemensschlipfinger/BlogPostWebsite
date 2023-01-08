using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities; 

[Table("COMMENTS")]
public class Comment: APost {

    [Required]
    [Column("PARENT_POST_ID")]
    public int ParentPostId { get; set; }

    public virtual APost ParentPost { get; set; }
    
}