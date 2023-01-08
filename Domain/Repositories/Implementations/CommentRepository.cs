using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class CommentRepository : ARepository<Comment>
{
    public CommentRepository(ModelDbContext context) : base(context)
    {
        
    }
}