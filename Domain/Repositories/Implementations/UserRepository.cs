using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class UserRepository : ARepository<User>
{
    public UserRepository(ModelDbContext context) : base(context)
    {
    }

    public async Task<bool> CheckIfUserExistsAsync(string userName)
    {
        return await base.Table.AnyAsync(u => u.UserName == userName);
    }
    
    public bool CheckIfUserExists(string userName)
    {
        return base.Table.Any(u => u.UserName == userName);
    }
    
    public async Task<User?> ReadAsync(string id) => Table.Find(id);
    

    public async Task<User?> GetUserByPost(APost blogPost)
    {
        return await Context.Posts.Where(p => p.Id == blogPost.Id)?.Join(Context.Users, p => p.AuthorId, u => u.Id, (b, u) => u).FirstAsync();
    }
    
}