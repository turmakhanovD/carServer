using System;
using System.ComponentModel.DataAnnotations;

namespace CarApplication.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Mark { get; set; }
        [Display(Name = "Engine Volume")]
        public string EngineVolume { get; set; }
        
        public decimal Price { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }
        
    }
    
}
