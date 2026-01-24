using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using TeduBlog.Core.Domain.Content;
using TeduBlog.Core.Repositories;
using TeduBlog.Data.SeedWorks;

namespace TeduBlog.Data.Repositories;

public class PostRepository : RepositoryBase<Post, Guid>, IPostRepository
{
    public PostRepository(TeduBlogContext context) : base(context)
    {
    }

    public void Add(Post entity)
    {
        throw new NotImplementedException();
    }

    public void AddRange(IEnumerable<Post> entities)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Post> Find(Expression<Func<Post, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Post>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Post> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Post>> GetPopularPostAsync(int count)
    {
        return await _context.Posts.OrderByDescending(x => x.ViewCount).Take(count).ToListAsync();
    }

    public void Remove(Post entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<Post> entities)
    {
        throw new NotImplementedException();
    }
}
