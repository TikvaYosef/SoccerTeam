using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoccerTeam.Models
{
    public class Player
    {
       
        public int id { set; get; }

        [Required]
        public string Fname { set; get; }
        [Required,MaxLength(15)]
        public string Lname { set; get;}
        public string position { set; get; }
        public int age { set; get; }
    }
}