using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Learning.Asp.Net.Core2.Pages.Books;

using Domain;
using Domain.Entities;

public class EditModel : PageModel
{
    private readonly IUnitOfWork _unitOfWork;

    public EditModel(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [BindProperty]
    public Book Book { get; set; }

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (!id.HasValue) return NotFound();
        
        Book = (await _unitOfWork.BookRepository.GetAllAsync()).FirstOrDefault(book => book.Id == id);
        return Book is null ? NotFound() : Page();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid) return Page();

        _unitOfWork.BookRepository.Update(Book);

        return RedirectToPage("./Index");
    }
}