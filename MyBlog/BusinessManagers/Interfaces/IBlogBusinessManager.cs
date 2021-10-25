using Microsoft.AspNetCore.Mvc;
using MyBlog.Data.Models;
using MyBlog.Models.BlogViewModels;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyBlog.BusinessManagers.Interfaces
{
    public interface IBlogBusinessManager
    {
        Task<Blog> CreateBlog(CreateViewModel createBlogViewModel, ClaimsPrincipal claimsPrincipal);

        Task<ActionResult<EditViewModel>> GetEditViewModel(int? id, ClaimsPrincipal claimsPrincipal);

        Task<ActionResult<EditViewModel>> UpdateBlog(EditViewModel editViewModel, ClaimsPrincipal claimsPrincipal);
    }
}