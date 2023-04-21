using System.ComponentModel.DataAnnotations;

namespace NetkinetixEvents.Models
{
    public class SiteEvent
    {
        [Key]
        public int seId { get; set; }
        [Required]
        [Range(1,128, ErrorMessage ="Title can only be up to 128 characters and is required")]
        public string seTitle { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime seStartDate { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? seEndDate { get; set;}
        [Range(0, 128, ErrorMessage = "Title can only be up to 128 characters")]
        public string? seLocation { get; set; }
        [Range(0, 4000, ErrorMessage = "Title can only be up to 4000 characters")]
        public string? seDescription { get; set; }
        [Range(0, 2048, ErrorMessage = "Title can only be up to 2048 characters")]
        public string? seURL { get; set; }
        public bool seActive { get; set; } 
    }
}
