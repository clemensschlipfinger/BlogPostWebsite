using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class CommentRepository : ARepository<Comment>
{
    public CommentRepository(ModelDbContext context) : base(context)
    {
        
    }
    
    
    public async Task<List<Comment>?> GetCommentsByPost(APost post)
    {
        var comments = await Context.Posts.Where(p => p.Id == post.Id)
            ?.Join(Context.Comments, p => p.Id, c => c.ParentPostId, (b, c) => c).ToListAsync();
        
        foreach (var c in comments)
        {
            c.Author = await Context.Users.Where(u => u.Id == c.AuthorId).FirstAsync();
            c.ChildComments = await GetCommentsByPost(c);
        }

        return comments;
    }
}