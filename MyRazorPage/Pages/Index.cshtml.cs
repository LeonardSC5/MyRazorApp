using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorPage.Pages
{
    public class IndexModel : PageModel
    {
        public List<Category> Categories { get; set; } = new();
        public async Task OnGet()
        {
            await Task.Delay(5000);
            for (var i = 0; i <= 100; i++)
            {
                Categories.Add(item: new Category(i, Title: "Categoria", Price: i * 18.95M));
            }
        }

        public void OnPost() 
        { 
        }


        public record Category(int Id, string Title, decimal Price);
    }
}
