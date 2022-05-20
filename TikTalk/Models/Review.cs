using System.ComponentModel.DataAnnotations;

namespace TikTalk.Models

{
    public class Review
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Rate is required")]
        [Range(1, 5, ErrorMessage = "Range must be between 1 and 5")]
        public int Rate { get; set; }

        public string Feedback { get; set; }

        public DateTime Time { get; set; } = DateTime.Now;
    }
   
}
