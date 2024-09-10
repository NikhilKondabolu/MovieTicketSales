using Microsoft.Extensions.Logging;
using System.Reflection;

namespace KondaboluTicketSales.Models
{
    public class EventService
    {
        // created by Kondabolu
        /* This is a class that creates a list of events with each event of type event class
         * creates a list of categories with each category of type category class
         has three methods:
        Get events() which returns events based on incoming parameter category
        Get categorys() that returns the list of categories or events
        getAllEvents() will return all categories */

        private List<Events> _allEvents = new()
        {
            new Events(){Id=100, Title="The Lion King", CategoryId=1, TicketPrice = 50, Description="Muscial Based on Disney's animated movie", ImageId="100.png"},
            new Events(){Id=200, Title="Holiday Spectacular", CategoryId=2 , TicketPrice = 40, Description="Holiday extravaganza for the entire family", ImageId="200.png"},
            new Events(){Id=300, Title="Mary Poppins", CategoryId=1, TicketPrice = 50, Description="The popular musical with seven tony awards.", ImageId="300.png"},
            new Events(){Id=400, Title="Taylor Swift", CategoryId=2, TicketPrice = 90, Description="Popular singer and songwriter", ImageId="400.png"},
            new Events(){Id=500, Title="Alice in Wonderland",CategoryId=1, TicketPrice=90,Description="Alice in Wonderland and through the looking-glass by lewis carroll",ImageId="500.png"}

        };
        private List<Category> _allCategories = new()
        {

            new Category (){Id=1, CategoryName="Theater Show"},
            new Category(){Id=2, CategoryName="Concert"}

        };
        //Method returns events based on incoming parameter category
        public Events GetEvents(int id)
        {

            //incoming parameter id comes from the <a> link in the details view where ID is either all, or a specific category name.
            Events? selectedEvents = null;
            foreach (Events anEvent in _allEvents)
            {
                if (anEvent.Id == id)
                {
                    selectedEvents = anEvent;
                }//if
            }
            return selectedEvents;
        }//getevent()

        public List<Category> GetCategories() { return _allCategories; }
        public List<Events> GetAllEvents() { return _allEvents; }
    }
}
