using Microsoft.AspNetCore.Mvc;
using Module.Data;
using Module.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class LocationTravelController : Controller
    {

        private readonly ApplicationDBContext _db;
        public LocationTravelController(ApplicationDBContext db)
        {
            _db = db;
        }

		// /LocationTravel/AllLocationTravel
		[HttpGet]
		[Route("AllLocationTravel")]
		public IActionResult AllLocationTravel() {
			IEnumerable<LocationTravel> locationTravels = _db.LocationTravels;

			return Ok(locationTravels);
		}


		// /LocationTravel/FindLocationTravelByID
		[HttpGet]
		[Route("FindLocationTravelByID/{id}")]
		public ActionResult FindLocationTravelByID(int id)
        {
            var locationTravelByID = _db.LocationTravels.Find(id);
            if (locationTravelByID == null || id == 0)
            {
                return NotFound();
            }
            else if (ModelState.IsValid)
            {
                return Ok(locationTravelByID);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

    }
}
