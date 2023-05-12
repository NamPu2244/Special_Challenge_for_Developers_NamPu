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
	public class LocationRestController : Controller
    {

        private readonly ApplicationDBContext _db;
        public LocationRestController(ApplicationDBContext db)
        {
            _db = db;
        }

		// /LocationRest/AllLocationRest
		[HttpGet]
		[Route("AllLocationRest")]
		public IActionResult AllLocationRest() {
			IEnumerable<LocationRest> locationRests = _db.LocationRests;

			return Ok(locationRests);
		}

		// /LocationRest/FindLocationRestByID
		[HttpGet]
		[Route("FindLocationRestByID/{id}")]
		public ActionResult FindLocationRestByID(int id)
        {
            var locationRestByID = _db.LocationRests.Find(id);
            if (locationRestByID == null || id == 0)
            {
                return NotFound();
            }
            else if (ModelState.IsValid)
            {
                return Ok(locationRestByID);
            }
            else
            {
                return BadRequest(ModelState);
            }

        }


    }
}
