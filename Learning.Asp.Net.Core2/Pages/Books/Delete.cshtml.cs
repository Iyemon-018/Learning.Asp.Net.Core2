using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Learning.Asp.Net.Core2.Pages.Books;

using Domain;
using Domain.Entities;

public class DeleteModel : PageModel
{
    private readonly IUnitOfWork _unitOfWork;

    public DeleteModel(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [BindProperty]
    public Book Book { get; set; }

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (!id.HasValue) return NotFound();

        Book = await _unitOfWork.BookRepository.FindAsync(id.Value);
        return Page();
    }

    public IActionResult OnPost()
    {
        _unitOfWork.BookRepository.Remove(Book);

        return RedirectToPage("./Index");
    }
}