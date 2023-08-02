using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eCommerceMVCApp.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        public List<Actor_Movies> Actors_Movies{ get; set; }
    }
}
