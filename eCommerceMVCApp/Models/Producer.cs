using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eCommerceMVCApp.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }
        public List<Movie> Movies{ get; set; }
    }
}
