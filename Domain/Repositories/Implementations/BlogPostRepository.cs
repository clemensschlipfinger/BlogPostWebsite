using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class BlogPostRepository : ARepository<BlogPost>
{
    public BlogPostRepository(ModelDbContext context) : base(context)
    {
        
    }
}