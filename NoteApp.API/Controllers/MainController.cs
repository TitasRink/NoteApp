using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NoteApp.Bussness.Interfaces;
using NoteApp.Repository.DTO;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace NoteApp.API.Controllers
{
    [Route("api/Services")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly INoteService _noteService;
        private readonly ICategoryService _categoryService;
        

        public MainController(INoteService noteService, ICategoryService categoryService)
        {
            _noteService = noteService;
            _categoryService = categoryService;
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpPost("Create_note_and_mesage"), Authorize]
        public ActionResult Create([FromBody] NoteDTO note)
        {
            var result = _noteService.CreateNoteAndMessage(note.Name, note.Message, note.IdName);
            return Ok(result);
        }

        [HttpPost("Move note to category"), Authorize]
        public ActionResult MoveNote(string category, string note)
        {
            var result = _noteService.MoveNoteToCategory(category, note);
            return Ok(result);
        }

        [HttpPost("Update Note"), Authorize]
        public ActionResult UpdateNote(string oldnote, string newnote)
        {
            var result = _noteService.UpdateNote(oldnote, newnote);
            return Ok(result);
        }

        [HttpDelete("Remove Note"), Authorize]
        public ActionResult RemoveNote(string name)
        {
            var result = _noteService.DeleteNote(name);
            return Ok(result);
        }

        [HttpPost("Create Category"), Authorize]
        public ActionResult Createcategory(string name)
        {
            var result = _categoryService.CreateCategory(name);
            return Ok(result);
        }

        [HttpPost("Rename category name"), Authorize]
        public ActionResult UpdateCategory(string oldname, string newname)
        {
            var result = _categoryService.UpdateCategoryName(oldname, newname);
            return Ok(result);
        }

        [HttpDelete("Remove Category"), Authorize]
        public ActionResult RemoveCategory(string name)
        {
            var result = _categoryService.DeleteCategory(name);
            return Ok(result);
        }

       
        [HttpPost("Find all Notes by category"), Authorize]
        public async Task<ActionResult> FindNotesByCastegory(string category)
        {
            var result = await Task.Run(() => _noteService.FilterByCategory(category));
            return Ok(result);
        }

        [HttpPost("Find all Notes by name"), Authorize]
        public async Task<ActionResult> FindNotesByName(string name)
        {
            var result = await Task.Run(() => _noteService.FilterByNote(name));
            return Ok(result);
        }
    }
}
