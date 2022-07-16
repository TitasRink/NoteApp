﻿using Microsoft.AspNetCore.Authorization;
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
        public ActionResult Create([FromBody] NoteDTO note)
        {
            var result = _noteService.CreateNoteAndMessage(note.Name, note.Message, note.IdName);
            return Ok(result);
        }

        [HttpPost("Create_Category"), Authorize]
        public ActionResult Createcategory([FromBody] CategoryDTO category)
        {
            var result = _categoryService.CreateCategory(category.Name, category.UserNameId);
            return Ok(result);
        }

        [HttpPost("Remove_Note"), Authorize]
        public ActionResult RemoveNote([FromBody] NoteDTO note)
        {
            var result = _noteService.DeleteNote(note.Name);
            return Ok(result);
        }
        //neveikia dar su UI
        [HttpPost("Move_note_to_category"), Authorize]
        public ActionResult MoveNote([FromBody] CategoryDTO category)
        {
            var result = _noteService.MoveNoteToCategory(category.Name , category.UserNameId);
            return Ok(result);
        }

        [HttpPost("Update_Note"), Authorize]
        public ActionResult UpdateNote([FromBody] NoteDTO note)
        {
            var result = _noteService.UpdateNote(note.Name, note.Message);
            return Ok(result);
        }

        [HttpPost("Rename_category_name"), Authorize]
        public ActionResult UpdateCategory(CategoryDTO category)
        {
            var result = _categoryService.UpdateCategoryName(category.Name, category.UserNameId);
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
