using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Learning.Asp.Net.Core2.Pages.Books;

using Domain;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

public class CreateModel : PageModel
{
    private readonly IUnitOfWork _unitOfWork;

    public CreateModel(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;

        Book = new Book();
    }

    [BindProperty]
    public Book Book { get; set; }

    public SelectList Publishes { get; set; }

    public async Task<IActionResult> OnGet()
    {
        var list = (await _unitOfWork.BookRepository.GetAllAsync()).Select(book => new {Publisher = book.Publisher}).Distinct();
        Publishes = new SelectList(list, "Publisher", "Publisher");
        return Page();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid) return Page();

        _unitOfWork.BookRepository.Add(Book);

        return RedirectToPage("./Index");
    }
}