using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Models
{
    public class LocationTravel
    {
        [Key]
        public int LocationTravelID { get; set; }
        public string LocationTravelName { get; set; }
        public string LocationTravelDetail { get; set;}
        public string LocationTravelPicture { get; set; }
	}
}
