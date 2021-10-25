using Microsoft.EntityFrameworkCore;
using MyBlog.Data;
using MyBlog.Data.Models;
using MyBlog.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Services
{
    public class BlogService : IBlogService
    {
        private readonly ApplicationDbContext applicationDbContext;
        public BlogService (ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
      
        public Blog GetBlog(int blogId)
        {
            return applicationDbContext.Blogs.FirstOrDefault(blog => blog.id == blogId);
        }

        public IEnumerable<Blog> GetBlogs(ApplicationUser applicationUser)
        {
            
            return applicationDbContext.Blogs
                .Include(blog => blog.Approver)
                .Include(blog => blog.Posts)
                .Include(blog => blog.Creator)
                .Where(blog => blog.Creator == applicationUser);
            
        }

        public async Task<Blog> Add(Blog blog)
        {
            applicationDbContext.Add(blog);
            await applicationDbContext.SaveChangesAsync();
            return blog;
        }

        public async Task<Blog> Update(Blog blog)
        {
            applicationDbContext.Update(blog);
            await applicationDbContext.SaveChangesAsync();
            return blog;
        }
    }
}
