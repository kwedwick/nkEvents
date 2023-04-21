using System.ComponentModel.DataAnnotations;

namespace NetkinetixEvents.Models
{
    public class EventSearch
    {
        public string? seTitle { get; set; } = null;
        public DateTime? seStartDate { get; set; } = null;
        public DateTime? seEndDate { get; set; } = null;
    }
}
