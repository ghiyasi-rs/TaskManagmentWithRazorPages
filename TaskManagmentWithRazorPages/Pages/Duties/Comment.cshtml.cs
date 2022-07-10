using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces.Repository;

using Microsoft.AspNetCore.Mvc.ViewFeatures;
using TaskManagmentWithRazorPages.Pages.Duties.ViewModels;
namespace TaskManagmentWithRazorPages.Pages.Duties
{
    public class CommentModel : PageModel
    {
        ICommentRepository _commentRepository;

        public Comment _comment;

        public CommentModel(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
          

        }

        public async Task OnGet(int commentId)        {
          
            _comment = await _commentRepository.GetByIdAsync(commentId);

        }
        
    }
}
