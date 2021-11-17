using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }//prop + tab(x2)
        public string ProfilePictureUrl { get; set; } 
        public String FullName { get; set; }
        public String Bio { get; set; }

        //Relaciones 
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
