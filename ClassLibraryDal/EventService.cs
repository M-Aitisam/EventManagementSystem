using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibraryModel;

namespace ClassLibraryDal
{
    public class EventService
    {
        private static readonly List<Event> events = new List<Event>();
        private static readonly List<Ticket> tickets = new List<Ticket>();



        // Get all events
        public async Task<List<Event>> GetEvents()
        {
            await Task.Delay(100); // Simulate async delay (e.g., from a database)
            return events;
        }

        // Create a new event
        public async Task CreateEvent(Event newEvent)
        {
            await Task.Delay(100); // Simulate async delay

            if (newEvent == null) throw new ArgumentNullException(nameof(newEvent));

            newEvent.Id = events.Count > 0 ? events.Max(e => e.Id) + 1 : 1; // Assign ID based on existing events
            events.Add(newEvent);
        }

        // Update an existing event
        public async Task UpdateEvent(Event updatedEvent)
        {
            await Task.Delay(100); // Simulate async delay

            if (updatedEvent == null) throw new ArgumentNullException(nameof(updatedEvent));

            var eventToUpdate = events.FirstOrDefault(e => e.Id == updatedEvent.Id);
            if (eventToUpdate == null)
            {
                throw new InvalidOperationException($"Event with ID {updatedEvent.Id} not found.");
            }

            // Update event details
            eventToUpdate.Name = updatedEvent.Name;
            eventToUpdate.Date = updatedEvent.Date;
            eventToUpdate.Description = updatedEvent.Description;
            eventToUpdate.Location = updatedEvent.Location;
            eventToUpdate.StartTime = updatedEvent.StartTime;
            eventToUpdate.EndTime = updatedEvent.EndTime;
            eventToUpdate.TimeZone = updatedEvent.TimeZone;
            eventToUpdate.MultipleDates = updatedEvent.MultipleDates;
        }

        // Delete an event by ID
        public async Task DeleteEvent(int eventId)
        {
            await Task.Delay(100); // Simulate async delay

            var eventToDelete = events.FirstOrDefault(e => e.Id == eventId);
            if (eventToDelete == null)
            {
                throw new InvalidOperationException($"Event with ID {eventId} not found.");
            }

            events.Remove(eventToDelete);
        }

        // Create a ticket for a specific event
        public async Task<Ticket> CreateTicketAsync(int eventId, string userName, string description, int numberOfTickets, decimal price, string ticketType, DateTime eventDate)
        {
            await Task.Delay(100); // Simulate async delay

            var ticket = new Ticket
            {
                Id = tickets.Count + 1,
                UserName = userName,
                Description = description,
                NumberOfTickets = numberOfTickets,
                Price = price,
                TicketType = ticketType,
                EventDate = eventDate
            };

            tickets.Add(ticket);
            return ticket;
        }

        // Get tickets by event ID
        public async Task<List<Ticket>> GetTicketsByEventIdAsync(int eventId)
        {
            await Task.Delay(100); // Simulate async delay
            return tickets.Where(t => t.EventId == eventId).ToList();
        }

        // Update a ticket's details
        public async Task UpdateTicketAsync(Ticket updatedTicket)
        {
            await Task.Delay(100); // Simulate async delay

            if (updatedTicket == null) throw new ArgumentNullException(nameof(updatedTicket));

            var ticketToUpdate = tickets.FirstOrDefault(t => t.Id == updatedTicket.Id);
            if (ticketToUpdate == null)
            {
                throw new InvalidOperationException($"Ticket with ID {updatedTicket.Id} not found.");
            }

            // Update ticket details
            ticketToUpdate.UserName = updatedTicket.UserName;
            ticketToUpdate.Description = updatedTicket.Description;
            ticketToUpdate.NumberOfTickets = updatedTicket.NumberOfTickets;
            ticketToUpdate.Price = updatedTicket.Price;
            ticketToUpdate.TicketType = updatedTicket.TicketType;
            ticketToUpdate.EventDate = updatedTicket.EventDate;
        }

        

        // Simulating async bulk event deletion
        public async Task DeleteMultipleEvents(List<int> eventIds)
        {
            foreach (var id in eventIds)
            {
                await DeleteEvent(id);
            }
        }
    }
}