//created by Kondabolu
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Extensions.Logging;

namespace KondaboluTicketSales.Models
{
    public class ListViewModel
    {
        //Properties        
        public IEnumerable<Events> Events { get; }
        public List<Category> Categories { get; }

        public String? SelectedCategory { get; }

        // Constructor which accepts events, categories, and the selected category
        public ListViewModel(IEnumerable<Events> events, List<Category> categories, string selectedCategory)
        {
            Events = events;
            Categories = categories;
            SelectedCategory = selectedCategory;
        }
    }
}
