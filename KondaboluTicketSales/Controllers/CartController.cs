using KondaboluTicketSales.Models;
using Microsoft.AspNetCore.Mvc;

namespace KondaboluTicketSales.Controllers
{
    public class CartController : Controller
    {
        // created by Kondabolu


        //Action method to handle Buy tickets
        public IActionResult Buy(int id)
        {
            EventService eventService = new EventService();
            Events selectedEvent = eventService.GetEvents(id);
            BuyTicketsModel buyTickets = new BuyTicketsModel(selectedEvent.Title, selectedEvent.TicketPrice);
            return View(buyTickets);
        }
        public IActionResult Confirmation(BuyTicketsModel model)
        {
            // Check if the model state is valid or not
            if (ModelState.IsValid)
            {
                // Calculate the amount using the model method
                model.CalculateAmountDue();
                return View(model);
            }
            //return but view if state is not valid
            return View("Buy", model);
        }
    }
}
