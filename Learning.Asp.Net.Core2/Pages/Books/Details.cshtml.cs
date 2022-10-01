namespace Learning.Asp.Net.Core2.Pages.Books;

using Domain;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class DetailsModel : PageModel
{
    private readonly IUnitOfWork _unitOfWork;

    public DetailsModel(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public Book Book { get; set; }

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (!id.HasValue) return NotFound();

        Book = (await _unitOfWork.BookRepository.GetAllAsync()).FirstOrDefault(book => book.Id == id);

        return Book is null ? NotFound() : Page();
    }
}