using Microsoft.AspNetCore.Identity;
using MyBlog.BusinessManagers.Interfaces;
using MyBlog.Data.Models;
using MyBlog.Models.AdminViewModels;
using MyBlog.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyBlog.BusinessManagers
{
    public class AdminBusinessManager : IAdminBusinessManager
    {
        private UserManager<ApplicationUser> userManager;
        private IBlogService blogService;

        public AdminBusinessManager(UserManager<ApplicationUser> userManager,
            IBlogService blogService)
        {
            this.userManager = userManager;
            this.blogService = blogService;
        }

        public async Task<IndexViewModel> GetAdminDashboard(ClaimsPrincipal claimsPrincipal)
        {
            var applicationUser = await userManager.GetUserAsync(claimsPrincipal);

            return new IndexViewModel
            {
                Blogs = blogService.GetBlogs(applicationUser)
            };
        }
    }
}
