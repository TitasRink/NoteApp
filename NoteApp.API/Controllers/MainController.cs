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

        [HttpPost("Create_note_and_mesage"), Authorize]
        public ActionResult Create([FromBody] UserDTO note)
        {
            var result = _noteService.CreateNoteAndMessage(note.Name, note.Message, note.IdName);
            return Ok(result);
        }

        [HttpPost("Move_note_to_category"), Authorize]
        public ActionResult MoveNote(string category, string note)
        {
            var result = _noteService.MoveNoteToCategory(category, note);
            return Ok(result);
        }

        [HttpPost("Update_Note"), Authorize]
        public ActionResult UpdateNote(string oldnote, string newnote)
        {
            var result = _noteService.UpdateNote(oldnote, newnote);
            return Ok(result);
        }

        [HttpDelete("Remove_Note"), Authorize]
        public ActionResult RemoveNote(string name)
        {
            var result = _noteService.DeleteNote(name);
            return Ok(result);
        }

        [HttpPost("Create_Category"), Authorize]
        public ActionResult Createcategory([FromBody] CategoryDTO category)
        {
            var result = _categoryService.CreateCategory(category.Name, category.UserNameId);
            return Ok(result);
        }

        [HttpPost("Rename_category_name"), Authorize]
        public ActionResult UpdateCategory(string oldname, string newname)
        {
            var result = _categoryService.UpdateCategoryName(oldname, newname);
            return Ok(result);
        }

        [HttpDelete("Remove_Category"), Authorize]
        public ActionResult RemoveCategory(string name)
        {
            var result = _categoryService.DeleteCategory(name);
            return Ok(result);
        }

       
        [HttpPost("Find_all_Notes_by_category"), Authorize]
        public async Task<ActionResult> FindNotesByCastegory(string category)
        {
            var result = await Task.Run(() => _noteService.FilterByCategory(category));
            return Ok(result);
        }

        [HttpPost("Find_all_Notes_by_name"), Authorize]
        public async Task<ActionResult> FindNotesByName(string name)
        {
            var result = await Task.Run(() => _noteService.FilterByNote(name));
            return Ok(result);
        }
    }
}
