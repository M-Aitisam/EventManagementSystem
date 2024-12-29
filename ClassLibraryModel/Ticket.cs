using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModel
{
    public class Ticket
    {
        public int Id { get; set; } // Add the Id property
        public int EventId { get; set; }
        public string? UserName { get; set; }
        public string? Description { get; set; }
        public int NumberOfTickets { get; set; }
        public decimal Price { get; set; }
        public string? TicketType { get; set; }
        public DateTime EventDate { get; set; }

        // Other properties...
    }


}
