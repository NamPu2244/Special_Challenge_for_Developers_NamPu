using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Models
{
    public class LocationRest
    {
        [Key]
        public int LocationRestID { get; set; }
        public string LocationRestName { get; set; }
		public string LocationRestPicture { get; set; }
	}
}
