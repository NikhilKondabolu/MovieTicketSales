namespace KondaboluTicketSales.Models
{
    /* Created by Kondabolu
        * This class creates a type for Events
        * Each event has an event name, description for the event, the category of the event, and has an image to display
        */
    public class Events
    {
        //Properties
        public int Id { get; set; }
        public string? Title { get; set; }
        public int CategoryId { get; set; }
        public double TicketPrice  { get; set; }
        public string? Description { get; set; }
        public string? ImageId { get; set; }

    }//event class
}//namespace
