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
}