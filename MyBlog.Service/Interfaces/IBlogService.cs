using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Data.Models;
using MyBlog.Services;

namespace MyBlog.Services.Interfaces
{
    public interface IBlogService
    {
        Blog GetBlog(int blogId);

        IEnumerable<Blog> GetBlogs(ApplicationUser applicationUser);

        Task<Blog> Add(Blog blog);

        Task<Blog> Update(Blog blog);
    }
}
