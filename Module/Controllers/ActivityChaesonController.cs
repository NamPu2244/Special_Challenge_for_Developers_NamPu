using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Module.Data;
using Module.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ActivityChaesonController : Controller
    {
        private readonly ApplicationDBContext _db;

        public ActivityChaesonController(ApplicationDBContext db)
        {
            _db = db;
        }

		// /ActivityChaeson/AllActivityChaeson
		[HttpGet]
		[Route("AllActivityChaeson")]
		public IActionResult AllActivityChaeson() {
			IEnumerable<ActivityChaeson> activityChaesons = _db.ActivityChaesons;

			return Ok(activityChaesons);
		}

		// /ActivityChaeson/FindActivityChaesonByID
		[HttpGet]
		[Route("FindActivityChaesonByID/{id}")]
		public ActionResult FindActivityChaesonByID(int id)
        {
            var activityChaesonByID = _db.ActivityChaesons.Find(id);
            if (activityChaesonByID == null || id == 0)
            {
                return NotFound();
            }
            else if (ModelState.IsValid)
            {
                return Ok(activityChaesonByID);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

    }
}
