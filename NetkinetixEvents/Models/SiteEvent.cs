using System.ComponentModel.DataAnnotations;

namespace NetkinetixEvents.Models
{
    public class SiteEvent
    {
        [Key]
        public int seId { get; set; }
        [Required]
        [StringLength(128, ErrorMessage = "Title can only be up to 128 characters")]
        public string seTitle { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime seStartDate { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? seEndDate { get; set;}
        [StringLength(128, ErrorMessage = "Location can only be up to 128 characters")]
        public string? seLocation { get; set; }
        [StringLength(4000, ErrorMessage = "Description can only be up to 4000 characters")]
        public string? seDescription { get; set; }
        [StringLength(2048, ErrorMessage = "URL can only be up to 2048 characters")]
        public string? seURL { get; set; }
        public bool seActive { get; set; } 
    }
}
