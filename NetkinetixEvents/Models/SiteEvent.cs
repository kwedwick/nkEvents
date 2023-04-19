using System.ComponentModel.DataAnnotations;

namespace NetkinetixEvents.Models
{
    public class SiteEvent
    {
        [Key]
        public int SeId { get; set; }
        [Required]
        [Range(1,128, ErrorMessage ="Title can only be up to 128 characters")]
        public string SeTitle { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime SeStartDate { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? SeEndDate { get; set;}
        [Range(0, 128, ErrorMessage = "Title can only be up to 128 characters")]
        public string? SeLocation { get; set; }
        [Range(0, 4000, ErrorMessage = "Title can only be up to 4000 characters")]
        public string? SeDescription { get; set; }
        [Range(0, 2048, ErrorMessage = "Title can only be up to 2048 characters")]
        public string? SeURL { get; set; }
        public bool SeActive { get; set; } 

    }
}
