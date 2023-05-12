using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Models
{
    public class ActivityChaeson
    {
        [Key]
        public int ActivityChaesonID { get; set; }
        public string ActivityChaesonName { get; set; }
        public string ActivityChaesonDetail { get; set; }
		public string ActivityChaesonPicture { get; set; }
	}
}
