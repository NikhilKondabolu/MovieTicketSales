using KondaboluTicketSales.Models;
using Microsoft.AspNetCore.Mvc;

namespace KondaboluTicketSales.Controllers
{
    public class EventsController : Controller
    {
        //created by Kondabolu

        [ResponseCache(NoStore = true, Duration = 0)]

        public IActionResult EventList(String id = "All")
        {
            //uses eventservice to get the events,either all by default if there is no incoming value, or baassed on the Id of the event

            //   the eventsservice class

            EventService eventService = new EventService();

            //list of categories
            List<Category> categories = new List<Category>();

            //list of events

            List<Events> events = new List<Events>();

            //GET THE EVENTS BASED ON CATEGORY ID;

            if (id == "All")
            {
                //get all Events
                events = eventService.GetAllEvents();
            }
            else
            {
                //based on ID fund category id:
                int selectedCategoryId = 0;
                foreach (Category cat in categories)
                {
                    if (cat.CategoryName == id)
                    {
                        selectedCategoryId = cat.Id;
                    }//IF

                }
                foreach (Events anEvent in eventService.GetAllEvents())
                {
                    if (anEvent.CategoryId == selectedCategoryId)
                    {
                        events.Add(anEvent);
                    }//id
                }//looping for finding events
            }//return ListViewModel as a viewmodel with a collection of events
            ListViewModel listViewModel = new ListViewModel(events, categories, id);

            return View(listViewModel);
        }//eventlist()
        [ResponseCache(NoStore = true, Duration = 0)]

        //Action method to handle Details
        public IActionResult Details(int id)
        {
            EventService eventService = new EventService();
            Events oneEvent = eventService.GetEvents(id);
            return View(oneEvent);
        }
    }
}
