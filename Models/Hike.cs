using System;  
using System.Collections.Generic;  
using System.ComponentModel.DataAnnotations;  
using System.Linq;  
using System.Threading.Tasks;  
  
namespace sampleproject.Models  
{  
    public class Hike  
    {  
        
        public int ID { get; set; }  
        [Required]  

        [Display(Name = "Hike Name")]
        public string HikeName { get; set; }  
        [Required]  
        public string Distance { get; set; }  
        [Required] 

        [Display(Name = "Hike Location")] 
        public string HikeLocation { get; set; }  
        [Required] 

        [Display(Name = "Elevation Gain")] 
        public string ElevationGain { get; set; }  
    }  
}