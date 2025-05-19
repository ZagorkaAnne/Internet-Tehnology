using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab2_B.Models
{
	public class EventModel
	{
        public int Id { get; set; }
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Lokacija { get; set; }
    }
}