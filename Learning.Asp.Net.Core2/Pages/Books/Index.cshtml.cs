namespace Learning.Asp.Net.Core2.Pages.Books;

using Domain;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    private readonly IUnitOfWork _unitOfWork;

    public IndexModel(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IList<Book> Books { get; set; }
    
    public async Task OnGetAsync()
    {
        Books = new List<Book>(await _unitOfWork.BookRepository.GetAllAsync());
    }
}