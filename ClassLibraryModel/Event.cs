namespace ClassLibraryModel
{
    public class Event
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Name { get; set; }
        public DateTime Date { get; set; }
        public string? Time { get; set; }
        public bool IsSelected { get; set; }
        public string? TimeZone { get; set; }
        public TimeSpan? StartTime { get; set; }  // Change to TimeSpan
        public TimeSpan? EndTime { get; set; }    // Change to TimeSpan
        public string? Location { get; set; }
        public bool MultipleDates { get; set; }
        public string? Type { get; set; }
        public string? ImageUrl { get; set; }
        public string? CustomerName { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public int TicketsSold = 12;
        public string? ServiceType { get; set; }
        public string Status
        {
            get
            {
                if (Date < DateTime.Today)
                    return "Past";
                else if (Date == DateTime.Today)
                    return "Ongoing";
                else
                    return "Upcoming";
            }
        }


    }
}
