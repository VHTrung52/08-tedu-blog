using System.Linq.Expressions;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TeduBlog.Core.Domain.Content;
using TeduBlog.Core.Models;
using TeduBlog.Core.Models.Content;
using TeduBlog.Core.Repositories;
using TeduBlog.Data.SeedWorks;

namespace TeduBlog.Data.Repositories;

public class PostRepository : RepositoryBase<Post, Guid>, IPostRepository
{
    private readonly IMapper _mapper;
    public PostRepository(TeduBlogContext context, IMapper mapper) : base(context)
    {
        _mapper = mapper;
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

    public async Task<PagedResult<PostInListDto>> GetPostPagingAsync(string keyword, Guid? categoryId, int pageIndex = 1, int pageSize = 10)
    {
        var query = _context.Posts.AsQueryable();
        if (!string.IsNullOrWhiteSpace(keyword))
        {
            query = query.Where(x => x.Name.Contains(keyword));
        }
        if (categoryId.HasValue)
        {
            query = query.Where(x => x.CategoryId == categoryId.Value);
        }

        var totalRow = await query.CountAsync();

        query = query.OrderByDescending(x => x.DateCreated)
           .Skip((pageIndex - 1) * pageSize)
           .Take(pageSize);

        return new PagedResult<PostInListDto>
        {
            Results = await _mapper.ProjectTo<PostInListDto>(query).ToListAsync(),
            CurrentPage = pageIndex,
            RowCount = totalRow,
            PageSize = pageSize
        };

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
