using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class BlogPostRepository : ARepository<BlogPost>
{
    public BlogPostRepository(ModelDbContext context) : base(context)
    {
        
    }
    public async Task<List<BlogPost>> ReadRecentAsync(int limit = 100) { 
        var blogPosts = await Table.OrderBy(b => b.LastEditedAt).Reverse().Take(limit).ToListAsync();
        return blogPosts;
    }
}