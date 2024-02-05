 using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ShowsApp.Models
{
    public class Show
    {
        [Display(Name ="Show Id")]
        
        public int ShowId {get; set;}
        [Required]
        [Display(Name ="Title")]
        public string ShowTitle { get; set; } = string.Empty;
        [Required]
        [Display(Name ="Genre")]
        public string ShowGenre { get; set; } = string.Empty;
        [Required]
        [Display(Name ="Rating")]
        public double ShowRate { get; set; }
        [Required]
        [Display(Name ="Poster")]
        public string Image { get; set; } = string.Empty;
        [Required]
        [Display(Name ="Category")]
        public int CategoryId { get; set; }

    }
}