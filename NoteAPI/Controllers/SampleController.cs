using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace NoteAPI.Controllers
{
    public class SampleController : Controller
    {
        [HttpGet]
        [Authorize]
        public ActionResult<IEnumerable<string>> Load()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        [Authorize]
        public ActionResult<string> LoadOne(int id)
        {
            return "value";
        }
    }
}
